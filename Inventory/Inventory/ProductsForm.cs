using System.Data;
using System.Data.OleDb;

namespace inventory;

/// <summary>Create / Read / Update / Delete screen for the Products table.</summary>
public partial class ProductsForm : Form
{
    private int? selectedId;
    private readonly bool _isAdmin;

    public ProductsForm() : this(false) { }

    /// <param name="isAdmin">Only administrators may add or delete products; everyone else can view and update.</param>
    public ProductsForm(bool isAdmin)
    {
        _isAdmin = isAdmin;
        InitializeComponent();           // controls are defined in ProductsForm.Designer.cs
        ApplyRole();
        Shown += (s, e) => LoadProducts();
        UpdateButtons();
    }

    private void ApplyRole()
    {
        if (_isAdmin) return;
        btnAdd.Visible = false;
        btnDelete.Visible = false;
        btnUpdate.Top = btnAdd.Top;
        btnClear.Top = btnUpdate.Bottom + 8;
        lblTitle.Text = "Products  ·  view & update only";
    }

    // ---------------------------------------------------------------- designer event handlers
    private void txtSearch_TextChanged(object? sender, EventArgs e) => LoadProducts();
    private void grid_SelectionChanged(object? sender, EventArgs e) => ShowSelectedRow();
    private void grid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e) => StyleGrid();
    private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

    // ---------------------------------------------------------------- grid look (columns come from the data)
    private void StyleGrid()
    {
        if (grid.Columns.Count == 0) return;
        grid.Columns["ProductID"]!.Visible = false;
        grid.Columns["ProductName"]!.HeaderText = "Product";
        grid.Columns["Category"]!.HeaderText = "Category";
        grid.Columns["Quantity"]!.HeaderText = "Qty";
        grid.Columns["UnitPrice"]!.HeaderText = "Unit Price";
        grid.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
        grid.Columns["ReorderLevel"]!.HeaderText = "Reorder Level";
        grid.Columns["ProductName"]!.FillWeight = 160;

        // highlight low-stock rows (same rule the dashboard uses)
        foreach (DataGridViewRow row in grid.Rows)
        {
            if (row.Cells["Quantity"].Value is null or DBNull) continue;
            bool low = Convert.ToInt32(row.Cells["Quantity"].Value) <= Convert.ToInt32(row.Cells["ReorderLevel"].Value);
            row.DefaultCellStyle.BackColor = low ? Color.FromArgb(254, 226, 226) : Color.White;
        }
    }

    // ---------------------------------------------------------------- READ
    private void LoadProducts()
    {
        try
        {
            using var con = Database.GetConnection();
            con.Open();
            string sql = "SELECT ProductID, ProductName, Category, Quantity, UnitPrice, ReorderLevel FROM Products";
            using var cmd = new OleDbCommand { Connection = con };
            string term = txtSearch.Text.Trim();
            if (term != "")
            {
                sql += " WHERE ProductName LIKE ? OR Category LIKE ?";
                cmd.Parameters.AddWithValue("@name", "%" + term + "%");
                cmd.Parameters.AddWithValue("@cat", "%" + term + "%");
            }
            cmd.CommandText = sql + " ORDER BY ProductName";

            var table = new DataTable();
            using (var adapter = new OleDbDataAdapter(cmd)) adapter.Fill(table);
            grid.DataSource = table;
            grid.ClearSelection();
            ClearForm(clearGridSelection: false);
        }
        catch (Exception ex) { ShowError("Could not load products: " + ex.Message); }
    }

    private void ShowSelectedRow()
    {
        if (grid.SelectedRows.Count == 0) { selectedId = null; UpdateButtons(); return; }
        var r = grid.SelectedRows[0];
        selectedId = Convert.ToInt32(r.Cells["ProductID"].Value);
        txtName.Text = r.Cells["ProductName"].Value?.ToString() ?? "";
        txtCategory.Text = r.Cells["Category"].Value?.ToString() ?? "";
        numQty.Value = Clamp(r.Cells["Quantity"].Value, numQty);
        numPrice.Value = Clamp(r.Cells["UnitPrice"].Value, numPrice);
        numReorder.Value = Clamp(r.Cells["ReorderLevel"].Value, numReorder);
        UpdateButtons();
    }

    private static decimal Clamp(object? v, NumericUpDown n)
    {
        decimal d = v is null or DBNull ? 0m : Convert.ToDecimal(v);
        return Math.Min(Math.Max(d, n.Minimum), n.Maximum);
    }

    // ---------------------------------------------------------------- CREATE
    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (!_isAdmin) { ShowError("Only administrators can add products."); return; }
        if (!ValidateInput(out string name)) return;
        try
        {
            using var con = Database.GetConnection();
            con.Open();
            using var cmd = new OleDbCommand(
                "INSERT INTO Products (ProductName, Category, Quantity, UnitPrice, ReorderLevel) VALUES (?, ?, ?, ?, ?)", con);
            AddValueParameters(cmd, name);
            cmd.ExecuteNonQuery();
            LoadProducts();
            MessageBox.Show("Product added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) { ShowError("Could not add the product: " + ex.Message); }
    }

    // ---------------------------------------------------------------- UPDATE
    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (selectedId is null) { ShowError("Select a product in the table first."); return; }
        if (!ValidateInput(out string name)) return;
        try
        {
            using var con = Database.GetConnection();
            con.Open();
            using var cmd = new OleDbCommand(
                "UPDATE Products SET ProductName = ?, Category = ?, Quantity = ?, UnitPrice = ?, ReorderLevel = ? WHERE ProductID = ?", con);
            AddValueParameters(cmd, name);
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = selectedId.Value;   // must stay last (positional)
            cmd.ExecuteNonQuery();
            LoadProducts();
            MessageBox.Show("Product updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) { ShowError("Could not update the product: " + ex.Message); }
    }

    // ---------------------------------------------------------------- DELETE
    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (!_isAdmin) { ShowError("Only administrators can delete products."); return; }
        if (selectedId is null) { ShowError("Select a product in the table first."); return; }
        try
        {
            using var con = Database.GetConnection();
            con.Open();

            int history;
            using (var check = new OleDbCommand("SELECT COUNT(*) FROM StockTransactions WHERE ProductID = ?", con))
            {
                check.Parameters.Add("@id", OleDbType.Integer).Value = selectedId.Value;
                history = Convert.ToInt32(check.ExecuteScalar());
            }

            string msg = $"Delete \"{txtName.Text}\"? This cannot be undone.";
            if (history > 0) msg += $"\n\nNote: it has {history} stock transaction(s) on record.";
            if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using var cmd = new OleDbCommand("DELETE FROM Products WHERE ProductID = ?", con);
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = selectedId.Value;
            cmd.ExecuteNonQuery();
            LoadProducts();
        }
        catch (Exception ex) { ShowError("Could not delete the product: " + ex.Message); }
    }

    // ---------------------------------------------------------------- helpers
    private void AddValueParameters(OleDbCommand cmd, string name)
    {
        cmd.Parameters.Add("@name", OleDbType.VarWChar, 100).Value = name;
        cmd.Parameters.Add("@cat", OleDbType.VarWChar, 50).Value = txtCategory.Text.Trim();
        cmd.Parameters.Add("@qty", OleDbType.Integer).Value = (int)numQty.Value;
        cmd.Parameters.Add("@price", OleDbType.Currency).Value = numPrice.Value;
        cmd.Parameters.Add("@reorder", OleDbType.Integer).Value = (int)numReorder.Value;
    }

    private bool ValidateInput(out string name)
    {
        name = txtName.Text.Trim();
        if (name == "")
        {
            ShowError("Product name is required.");
            txtName.Focus();
            return false;
        }
        return true;
    }

    private void ClearForm(bool clearGridSelection = true)
    {
        selectedId = null;
        txtName.Clear(); txtCategory.Clear();
        numQty.Value = 0; numPrice.Value = 0; numReorder.Value = 0;
        if (clearGridSelection) grid.ClearSelection();
        UpdateButtons();
        txtName.Focus();
    }

    private void UpdateButtons()
    {
        btnAdd.Enabled = true;
        btnUpdate.Enabled = btnDelete.Enabled = selectedId is not null;
    }

    private static void ShowError(string msg) =>
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
