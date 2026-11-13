#nullable disable
namespace inventory;

partial class ProductsForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        pnlTop = new Panel();
        lblTitle = new Label();
        txtSearch = new TextBox();
        pnlEdit = new Panel();
        lblDetails = new Label();
        lblName = new Label();
        txtName = new TextBox();
        lblCategory = new Label();
        txtCategory = new TextBox();
        lblQty = new Label();
        numQty = new NumericUpDown();
        lblPrice = new Label();
        numPrice = new NumericUpDown();
        lblReorder = new Label();
        numReorder = new NumericUpDown();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        grid = new DataGridView();
        pnlTop.SuspendLayout();
        pnlEdit.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numReorder).BeginInit();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(25, 49, 79);
        pnlTop.Controls.Add(lblTitle);
        pnlTop.Controls.Add(txtSearch);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1094, 70);
        pnlTop.TabIndex = 2;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(116, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Products";
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtSearch.Font = new Font("Segoe UI", 10.5F);
        txtSearch.Location = new Point(790, 20);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search name or category...";
        txtSearch.Size = new Size(280, 26);
        txtSearch.TabIndex = 0;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // pnlEdit
        // 
        pnlEdit.BackColor = Color.White;
        pnlEdit.BorderStyle = BorderStyle.FixedSingle;
        pnlEdit.Controls.Add(lblDetails);
        pnlEdit.Controls.Add(lblName);
        pnlEdit.Controls.Add(txtName);
        pnlEdit.Controls.Add(lblCategory);
        pnlEdit.Controls.Add(txtCategory);
        pnlEdit.Controls.Add(lblQty);
        pnlEdit.Controls.Add(numQty);
        pnlEdit.Controls.Add(lblPrice);
        pnlEdit.Controls.Add(numPrice);
        pnlEdit.Controls.Add(lblReorder);
        pnlEdit.Controls.Add(numReorder);
        pnlEdit.Controls.Add(btnAdd);
        pnlEdit.Controls.Add(btnUpdate);
        pnlEdit.Controls.Add(btnDelete);
        pnlEdit.Controls.Add(btnClear);
        pnlEdit.Dock = DockStyle.Right;
        pnlEdit.Location = new Point(774, 70);
        pnlEdit.Name = "pnlEdit";
        pnlEdit.Size = new Size(320, 790);
        pnlEdit.TabIndex = 1;
        // 
        // lblDetails
        // 
        lblDetails.AutoSize = true;
        lblDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblDetails.ForeColor = Color.FromArgb(31, 41, 55);
        lblDetails.Location = new Point(18, 16);
        lblDetails.Name = "lblDetails";
        lblDetails.Size = new Size(125, 21);
        lblDetails.TabIndex = 0;
        lblDetails.Text = "Product details";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblName.Location = new Point(18, 55);
        lblName.Name = "lblName";
        lblName.Size = new Size(94, 17);
        lblName.TabIndex = 1;
        lblName.Text = "Product name";
        // 
        // txtName
        // 
        txtName.Font = new Font("Segoe UI", 10.5F);
        txtName.Location = new Point(18, 79);
        txtName.MaxLength = 100;
        txtName.Name = "txtName";
        txtName.Size = new Size(280, 26);
        txtName.TabIndex = 0;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblCategory.Location = new Point(18, 118);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(64, 17);
        lblCategory.TabIndex = 2;
        lblCategory.Text = "Category";
        // 
        // txtCategory
        // 
        txtCategory.Font = new Font("Segoe UI", 10.5F);
        txtCategory.Location = new Point(18, 142);
        txtCategory.MaxLength = 50;
        txtCategory.Name = "txtCategory";
        txtCategory.Size = new Size(280, 26);
        txtCategory.TabIndex = 1;
        // 
        // lblQty
        // 
        lblQty.AutoSize = true;
        lblQty.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblQty.Location = new Point(18, 181);
        lblQty.Name = "lblQty";
        lblQty.Size = new Size(62, 17);
        lblQty.TabIndex = 3;
        lblQty.Text = "Quantity";
        // 
        // numQty
        // 
        numQty.Font = new Font("Segoe UI", 10.5F);
        numQty.Location = new Point(18, 205);
        numQty.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numQty.Name = "numQty";
        numQty.Size = new Size(280, 26);
        numQty.TabIndex = 2;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblPrice.Location = new Point(18, 244);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(68, 17);
        lblPrice.TabIndex = 4;
        lblPrice.Text = "Unit price";
        // 
        // numPrice
        // 
        numPrice.DecimalPlaces = 2;
        numPrice.Font = new Font("Segoe UI", 10.5F);
        numPrice.Location = new Point(18, 268);
        numPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numPrice.Name = "numPrice";
        numPrice.Size = new Size(280, 26);
        numPrice.TabIndex = 3;
        numPrice.ThousandsSeparator = true;
        // 
        // lblReorder
        // 
        lblReorder.AutoSize = true;
        lblReorder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblReorder.Location = new Point(18, 307);
        lblReorder.Name = "lblReorder";
        lblReorder.Size = new Size(89, 17);
        lblReorder.TabIndex = 5;
        lblReorder.Text = "Reorder level";
        // 
        // numReorder
        // 
        numReorder.Font = new Font("Segoe UI", 10.5F);
        numReorder.Location = new Point(18, 331);
        numReorder.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numReorder.Name = "numReorder";
        numReorder.Size = new Size(280, 26);
        numReorder.TabIndex = 4;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(37, 99, 235);
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(18, 388);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(280, 40);
        btnAdd.TabIndex = 5;
        btnAdd.Text = "Add Product";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.FromArgb(22, 163, 74);
        btnUpdate.FlatAppearance.BorderSize = 0;
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(18, 436);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(280, 40);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update Selected";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(220, 38, 38);
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(18, 484);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(280, 40);
        btnDelete.TabIndex = 7;
        btnDelete.Text = "Delete Selected";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.FromArgb(100, 116, 139);
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnClear.ForeColor = Color.White;
        btnClear.Location = new Point(18, 532);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(280, 40);
        btnClear.TabIndex = 8;
        btnClear.Text = "Clear / New";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(31, 41, 55);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        grid.ColumnHeadersHeight = 36;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.Dock = DockStyle.Fill;
        grid.EnableHeadersVisualStyles = false;
        grid.Location = new Point(0, 70);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 30;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(774, 790);
        grid.TabIndex = 0;
        grid.DataBindingComplete += grid_DataBindingComplete;
        grid.SelectionChanged += grid_SelectionChanged;
        // 
        // ProductsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 251);
        ClientSize = new Size(1094, 860);
        Controls.Add(grid);
        Controls.Add(pnlEdit);
        Controls.Add(pnlTop);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(900, 540);
        Name = "ProductsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Manage Products";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlEdit.ResumeLayout(false);
        pnlEdit.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)numReorder).EndInit();
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }

    private Panel pnlTop;
    private Label lblTitle;
    private TextBox txtSearch;
    private Panel pnlEdit;
    private Label lblDetails, lblName, lblCategory, lblQty, lblPrice, lblReorder;
    private TextBox txtName, txtCategory;
    private NumericUpDown numQty, numPrice, numReorder;
    private Button btnAdd, btnUpdate, btnDelete, btnClear;
    private DataGridView grid;
}
