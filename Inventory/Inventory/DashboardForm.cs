using System.Data;
using System.Data.OleDb;

namespace inventory;

public partial class DashboardForm : Form
{
    private DataTable? _products;
    private DataView? _productView;
    private bool _arranging;
    private bool _isAdmin;

    public DashboardForm()
    {
        InitializeComponent();
        pnlHeader.Resize += (s, e) => ArrangeHeader();
        pnlCanvas.Resize += (s, e) => ArrangeDashboard();
        pnlProductsHeader.Resize += (s, e) => ArrangeProductsHeader();
        txtSearch.TextChanged += (s, e) => ApplyProductFilter();
        gridProducts.DataBindingComplete += (s, e) => FormatProductsGrid();
        gridProducts.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) OpenProductManager(); };
        Shown += (s, e) => { ArrangeHeader(); ArrangeDashboard(); LoadAll(); };
    }

    public DashboardForm(string fullName, string role = "User") : this()
    {
        _isAdmin = Database.IsAdmin(role);
        lblWelcome.Text = $"Welcome, {fullName}!" + (_isAdmin ? "  (Admin)" : "");
    }

    private void ArrangeHeader()
    {
        if (pnlHeader is null) return;
        if (pnlHeader.ClientSize.Width < 620)
        {
            lblBrand.Location = new Point(28, 12);
            lblWelcome.Location = new Point(28, 52);
            lblCaption.Visible = false;
            pnlHeader.Height = 100;
        }
        else
        {
            lblBrand.Location = new Point(28, 17);
            lblWelcome.Location = new Point(245, 19);
            lblCaption.Visible = true;
            pnlHeader.Height = 92;
        }
        btnLogout.Location = new Point(pnlHeader.ClientSize.Width - btnLogout.Width - 24, (pnlHeader.Height - btnLogout.Height) / 2);
    }

    private void ArrangeProductsHeader()
    {
        int w = pnlProductsHeader.ClientSize.Width;
        bool narrow = w < 420;
        btnProducts.Text = narrow ? "Manage" : "Manage Products";
        btnProducts.Width = narrow ? 90 : 150;
        btnProducts.Location = new Point(w - btnProducts.Width - 16, 14);

        txtSearch.Visible = w >= 520;
        int room = btnProducts.Left - 12 - (lblPanelProducts.Right + 16);
        txtSearch.Width = Math.Clamp(room, 120, 260);
        txtSearch.Location = new Point(btnProducts.Left - 12 - txtSearch.Width, 16);
    }

    private void ArrangeDashboard()
    {
        if (_arranging || pnlCanvas is null) return;
        _arranging = true;
        try
        {
            int w = Math.Max(280, pnlCanvas.ClientSize.Width);
            int gap = w < 620 ? 10 : 16;

            lblOverview.Location = new Point(0, 0);
            lblOverviewSub.Location = new Point(3, 44);

            int cols = w >= 820 ? 3 : w >= 560 ? 2 : 1;
            int cardW = (w - gap * (cols - 1)) / cols, cardH = 104, y = 84;
            Control[] cards = { pnlProducts, pnlLowStock, pnlValue };
            for (int i = 0; i < cards.Length; i++)
                cards[i].SetBounds((i % cols) * (cardW + gap), y + (i / cols) * (cardH + gap), cardW, cardH);
            y += ((cards.Length + cols - 1) / cols) * (cardH + gap) + 8;

            int productsH = Math.Max(380, pnlContent.ClientSize.Height - pnlContent.Padding.Vertical - y);
            pnlPanelProducts.SetBounds(0, y, w, productsH);
            y += productsH;

            if (pnlCanvas.Height != y) pnlCanvas.Height = y;
            pnlContent.AutoScrollMinSize = new Size(0, y + pnlContent.Padding.Vertical);
            ArrangeProductsHeader();
        }
        finally { _arranging = false; }
    }

    private void LoadAll()
    {
        LoadStats();
        LoadProducts();
    }

    private void LoadStats()
    {
        try
        {
            lblProductsValue.Text = Database.ReadScalar("SELECT COUNT(*) FROM Products").ToString("N0");
            lblLowValue.Text = Database.ReadScalar("SELECT COUNT(*) FROM Products WHERE Quantity <= ReorderLevel").ToString("N0");
            lblValueValue.Text = Database.ReadScalar("SELECT SUM(Quantity * UnitPrice) FROM Products").ToString("C0");
        }
        catch
        {
            lblProductsValue.Text = lblLowValue.Text = lblValueValue.Text = "-";
        }
    }

    private void LoadProducts()
    {
        try
        {
            var table = new DataTable();
            using (var con = Database.GetConnection())
            {
                con.Open();
                using var cmd = new OleDbCommand(
                    "SELECT ProductID, ProductName, Category, Quantity, UnitPrice, ReorderLevel FROM Products ORDER BY ProductName", con);
                using var adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(table);
            }

            table.Columns.Add("StockValue", typeof(decimal));
            table.Columns.Add("Status", typeof(string));
            foreach (DataRow r in table.Rows)
            {
                int qty = ToInt(r["Quantity"]), level = ToInt(r["ReorderLevel"]);
                r["StockValue"] = qty * ToDec(r["UnitPrice"]);
                r["Status"] = qty <= 0 ? "Out of stock" : qty <= level ? "Low stock" : "In stock";
            }

            _products = table;
            _productView = new DataView(table);
            gridProducts.DataSource = _productView;
            ApplyProductFilter();
        }
        catch
        {
            gridProducts.DataSource = null;
            gridProducts.Visible = false;
            lblProductsEmpty.Visible = true;
            lblProductsEmpty.Text = "Could not load products.";
        }
    }

    private void ApplyProductFilter()
    {
        if (_productView is null || _products is null) return;
        string term = txtSearch.Text.Trim();
        _productView.RowFilter = term == ""
            ? ""
            : $"ProductName LIKE '%{EscapeLike(term)}%' OR Category LIKE '%{EscapeLike(term)}%'";

        bool has = _productView.Count > 0;
        gridProducts.Visible = has;
        lblProductsEmpty.Visible = !has;
        lblProductsEmpty.Text = _products.Rows.Count == 0
            ? "No products yet. Click \"Manage Products\" to add your first item."
            : "No products match your search.";
        lblPanelProducts.Text = $"Products  ·  {_productView.Count}";
        ArrangeProductsHeader();
    }

    private void FormatProductsGrid()
    {
        var g = gridProducts;
        if (g.Columns.Count == 0 || g.Columns["Status"] is null) return;
        g.Columns["ProductID"]!.Visible = false;
        SetCol(g, "ProductName", "Product", 200);
        SetCol(g, "Category", "Category", 110);
        SetCol(g, "Quantity", "Qty", 60, "N0", true);
        SetCol(g, "UnitPrice", "Unit Price", 90, "C2", true);
        SetCol(g, "ReorderLevel", "Reorder At", 80, "N0", true);
        SetCol(g, "StockValue", "Stock Value", 100, "C2", true);
        SetCol(g, "Status", "Status", 100);

        foreach (DataGridViewRow row in g.Rows)
        {
            string status = row.Cells["Status"].Value?.ToString() ?? "";
            var cell = row.Cells["Status"].Style;
            cell.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            switch (status)
            {
                case "Out of stock":
                    cell.ForeColor = Color.FromArgb(220, 38, 38);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 242, 242);
                    break;
                case "Low stock":
                    cell.ForeColor = Color.FromArgb(217, 119, 6);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 251, 235);
                    break;
                default:
                    cell.ForeColor = Color.FromArgb(22, 163, 74);
                    row.DefaultCellStyle.BackColor = Color.White;
                    break;
            }
        }
    }

    private static void SetCol(DataGridView g, string name, string header, float weight, string? format = null, bool right = false)
    {
        var c = g.Columns[name];
        if (c is null) return;
        c.HeaderText = header;
        c.FillWeight = weight;
        if (format != null) c.DefaultCellStyle.Format = format;
        if (right)
        {
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }

    private static string EscapeLike(string s)
    {
        var sb = new System.Text.StringBuilder();
        foreach (char c in s)
        {
            if (c == '\'') sb.Append("''");
            else if (c is '*' or '%' or '[' or ']') sb.Append('[').Append(c).Append(']');
            else sb.Append(c);
        }
        return sb.ToString();
    }

    private static int ToInt(object? v) => v is null or DBNull ? 0 : Convert.ToInt32(v);
    private static decimal ToDec(object? v) => v is null or DBNull ? 0m : Convert.ToDecimal(v);

    private void OpenProductManager()
    {
        using var products = new ProductsForm(_isAdmin);
        products.ShowDialog(this);
        LoadAll();
    }

    private void btnProducts_Click(object? sender, EventArgs e) => OpenProductManager();

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Close();
    }
}
