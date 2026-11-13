#nullable disable
namespace inventory;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlHeader = new Panel(); lblBrand = new Label(); lblWelcome = new Label(); lblCaption = new Label(); btnLogout = new Button();
        pnlContent = new Panel(); pnlCanvas = new Panel(); lblOverview = new Label(); lblOverviewSub = new Label();
        pnlProducts = new Panel(); pnlLowStock = new Panel(); pnlValue = new Panel();
        lblProductsTitle = new Label(); lblProductsValue = new Label(); lblProductsHint = new Label();
        lblLowTitle = new Label(); lblLowValue = new Label(); lblLowHint = new Label();
        lblValueTitle = new Label(); lblValueValue = new Label(); lblValueHint = new Label();
        pnlPanelProducts = new Panel();
        pnlProductsHeader = new Panel();
        lblPanelProducts = new Label();
        gridProducts = new DataGridView();
        lblProductsEmpty = new Label();
        txtSearch = new TextBox(); btnProducts = new Button();
        SuspendLayout();

        // ---- header bar
        pnlHeader.BackColor = Color.FromArgb(25, 49, 79); pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 92; pnlHeader.Name = "pnlHeader";
        lblBrand.AutoSize = true; lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblBrand.ForeColor = Color.White; lblBrand.Location = new Point(28, 17); lblBrand.Text = "INVENTORY"; lblBrand.Name = "lblBrand";
        lblWelcome.AutoSize = true; lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblWelcome.ForeColor = Color.White; lblWelcome.Location = new Point(245, 19); lblWelcome.Text = "Welcome!"; lblWelcome.Name = "lblWelcome";
        lblCaption.AutoSize = true; lblCaption.Font = new Font("Segoe UI", 9F); lblCaption.ForeColor = Color.FromArgb(190, 211, 232); lblCaption.Location = new Point(245, 45); lblCaption.Text = "Inventory Management System"; lblCaption.Name = "lblCaption";
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnLogout.BackColor = Color.FromArgb(49, 76, 108); btnLogout.FlatStyle = FlatStyle.Flat; btnLogout.FlatAppearance.BorderColor = Color.FromArgb(130, 160, 190); btnLogout.ForeColor = Color.White; btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold); btnLogout.Location = new Point(970, 25); btnLogout.Size = new Size(100, 38); btnLogout.Text = "Logout"; btnLogout.Name = "btnLogout"; btnLogout.Click += btnLogout_Click;
        pnlHeader.Controls.AddRange(new Control[] { lblBrand, lblWelcome, lblCaption, btnLogout });

        // ---- scrolling content area (all dashboard blocks live on pnlCanvas)
        pnlContent.Dock = DockStyle.Fill; pnlContent.AutoScroll = true; pnlContent.BackColor = Color.FromArgb(246, 248, 251); pnlContent.Padding = new Padding(24); pnlContent.Name = "pnlContent";
        pnlCanvas.Dock = DockStyle.Top; pnlCanvas.Height = 620; pnlCanvas.BackColor = Color.FromArgb(246, 248, 251); pnlCanvas.Name = "pnlCanvas";
        lblOverview.AutoSize = true; lblOverview.Font = new Font("Segoe UI", 19F, FontStyle.Bold); lblOverview.ForeColor = Color.FromArgb(31, 41, 55); lblOverview.Location = new Point(0, 0); lblOverview.Text = "Overview"; lblOverview.Name = "lblOverview";
        lblOverviewSub.AutoSize = true; lblOverviewSub.Font = new Font("Segoe UI", 10F); lblOverviewSub.ForeColor = Color.FromArgb(107, 114, 128); lblOverviewSub.Location = new Point(3, 44); lblOverviewSub.Text = "A quick look at your inventory."; lblOverviewSub.Name = "lblOverviewSub";

        // ---- stat cards
        SetupCard(pnlProducts, "pnlProducts", lblProductsTitle, lblProductsValue, lblProductsHint, "Total Products", "0", "Items in catalog", Color.FromArgb(37, 99, 235));
        SetupCard(pnlLowStock, "pnlLowStock", lblLowTitle, lblLowValue, lblLowHint, "Low Stock", "0", "Needs restocking", Color.FromArgb(217, 119, 6));
        SetupCard(pnlValue, "pnlValue", lblValueTitle, lblValueValue, lblValueHint, "Inventory Value", "₱0", "Total stock value", Color.FromArgb(22, 163, 74));

        // Design-time layout only: at run time ArrangeDashboard() repositions these to fit the window.
        pnlProducts.Location = new Point(0, 84); pnlProducts.Size = new Size(330, 104);
        pnlLowStock.Location = new Point(346, 84); pnlLowStock.Size = new Size(330, 104);
        pnlValue.Location = new Point(692, 84); pnlValue.Size = new Size(330, 104);

        // ---- products list section (title + search + manage button + grid)
        SetupSection(pnlPanelProducts, "pnlPanelProducts", pnlProductsHeader, 60, lblPanelProducts, "Products", gridProducts, "gridProducts", lblProductsEmpty, "Loading products...");
        pnlPanelProducts.Location = new Point(0, 204); pnlPanelProducts.Size = new Size(1022, 400);
        txtSearch.Font = new Font("Segoe UI", 10F); txtSearch.PlaceholderText = "Search name or category..."; txtSearch.Size = new Size(240, 27); txtSearch.Location = new Point(300, 16); txtSearch.Name = "txtSearch";
        btnProducts.BackColor = Color.FromArgb(37, 99, 235); btnProducts.FlatStyle = FlatStyle.Flat; btnProducts.FlatAppearance.BorderSize = 0; btnProducts.ForeColor = Color.White; btnProducts.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold); btnProducts.Size = new Size(150, 32); btnProducts.Location = new Point(560, 14); btnProducts.Text = "Manage Products"; btnProducts.Name = "btnProducts"; btnProducts.Cursor = Cursors.Hand; btnProducts.Click += btnProducts_Click;
        pnlProductsHeader.Controls.Add(txtSearch); pnlProductsHeader.Controls.Add(btnProducts);

        pnlCanvas.Controls.AddRange(new Control[] { lblOverview, lblOverviewSub, pnlProducts, pnlLowStock, pnlValue, pnlPanelProducts });
        pnlContent.Controls.Add(pnlCanvas);

        AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 251); ClientSize = new Size(1100, 700); MinimumSize = new Size(640, 500);
        StartPosition = FormStartPosition.CenterScreen; WindowState = FormWindowState.Maximized; Text = "Inventory Management System";
        Controls.Add(pnlContent); Controls.Add(pnlHeader); Name = "DashboardForm";
        ResumeLayout(false);
    }

    private void SetupCard(Panel card, string name, Label title, Label value, Label hint, string t, string v, string h, Color accent)
    {
        card.BackColor = Color.White; card.BorderStyle = BorderStyle.FixedSingle; card.Size = new Size(240, 104); card.Name = name;
        var stripe = new Panel { Dock = DockStyle.Left, Width = 5, BackColor = accent };
        title.AutoSize = true; title.Font = new Font("Segoe UI", 9.5F); title.ForeColor = Color.FromArgb(107, 114, 128); title.Location = new Point(20, 12); title.Text = t; title.Name = "lbl" + t.Replace(" ", "");
        value.AutoSize = true; value.Font = new Font("Segoe UI", 22F, FontStyle.Bold); value.ForeColor = Color.FromArgb(31, 41, 55); value.Location = new Point(18, 33); value.Text = v;
        hint.AutoSize = true; hint.Font = new Font("Segoe UI", 8.5F); hint.ForeColor = Color.FromArgb(107, 114, 128); hint.Location = new Point(21, 78); hint.Text = h;
        card.Controls.AddRange(new Control[] { stripe, title, value, hint });
    }

    private void SetupSection(Panel section, string name, Panel header, int headerHeight, Label title, string titleText, DataGridView grid, string gridName, Label empty, string emptyText)
    {
        section.BackColor = Color.White; section.BorderStyle = BorderStyle.FixedSingle; section.Name = name; section.Size = new Size(340, 280);

        header.Dock = DockStyle.Top; header.Height = headerHeight; header.BackColor = Color.White;
        title.AutoSize = true; title.Font = new Font("Segoe UI", 12F, FontStyle.Bold); title.ForeColor = Color.FromArgb(31, 41, 55); title.Location = new Point(18, headerHeight == 60 ? 18 : 14); title.Text = titleText; title.Name = "lbl" + name.Substring(3);
        header.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 1, BackColor = Color.FromArgb(226, 232, 240) });
        header.Controls.Add(title);

        SetupGrid(grid, gridName);
        grid.Visible = false;

        empty.AutoSize = false; empty.Dock = DockStyle.Fill; empty.Font = new Font("Segoe UI", 10F, FontStyle.Italic); empty.ForeColor = Color.FromArgb(107, 114, 128); empty.TextAlign = ContentAlignment.MiddleCenter; empty.Text = emptyText;

        // Fill controls first, Top header last so docking resolves correctly.
        section.Controls.Add(grid); section.Controls.Add(empty); section.Controls.Add(header);
    }

    private void SetupGrid(DataGridView g, string name)
    {
        g.Name = name; g.Dock = DockStyle.Fill;
        g.ReadOnly = true; g.AllowUserToAddRows = false; g.AllowUserToDeleteRows = false; g.AllowUserToResizeRows = false; g.MultiSelect = false;
        g.RowHeadersVisible = false; g.SelectionMode = DataGridViewSelectionMode.FullRowSelect; g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        g.BackgroundColor = Color.White; g.BorderStyle = BorderStyle.None; g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; g.GridColor = Color.FromArgb(235, 239, 244);
        g.EnableHeadersVisualStyles = false; g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; g.ColumnHeadersHeight = 34; g.RowTemplate.Height = 32;
        g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(75, 85, 99);
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
        g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(75, 85, 99);
        g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        g.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F); g.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254); g.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
        g.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
    }

    private Panel pnlHeader, pnlContent, pnlCanvas, pnlProducts, pnlLowStock, pnlValue, pnlPanelProducts, pnlProductsHeader;
    private Label lblBrand, lblWelcome, lblCaption, lblOverview, lblOverviewSub, lblProductsTitle, lblProductsValue, lblProductsHint, lblLowTitle, lblLowValue, lblLowHint, lblValueTitle, lblValueValue, lblValueHint, lblPanelProducts, lblProductsEmpty;
    private DataGridView gridProducts;
    private TextBox txtSearch;
    private Button btnLogout, btnProducts;
}
