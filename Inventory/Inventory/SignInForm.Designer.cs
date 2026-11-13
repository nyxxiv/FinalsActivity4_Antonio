#nullable disable
namespace inventory;
partial class SignInForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        pnlBrand = new Panel();
        lblBrand = new Label();
        lblProduct = new Label();
        lblTagline = new Label();
        lblFeatures = new Label();
        pnlForm = new Panel();
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnSignIn = new Button();
        linkRegister = new LinkLabel();
        pnlBrand.SuspendLayout();
        pnlForm.SuspendLayout();
        SuspendLayout();
        // 
        // pnlBrand
        // 
        pnlBrand.BackColor = Color.FromArgb(25, 49, 79);
        pnlBrand.Controls.Add(lblBrand);
        pnlBrand.Controls.Add(lblProduct);
        pnlBrand.Controls.Add(lblTagline);
        pnlBrand.Controls.Add(lblFeatures);
        pnlBrand.Dock = DockStyle.Left;
        pnlBrand.Location = new Point(0, 0);
        pnlBrand.Margin = new Padding(4, 5, 4, 5);
        pnlBrand.Name = "pnlBrand";
        pnlBrand.Padding = new Padding(79, 92, 79, 92);
        pnlBrand.Size = new Size(600, 860);
        pnlBrand.TabIndex = 1;
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        lblBrand.ForeColor = Color.White;
        lblBrand.Location = new Point(79, 258);
        lblBrand.Margin = new Padding(4, 0, 4, 0);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(208, 54);
        lblBrand.TabIndex = 0;
        lblBrand.Text = "Inventory";
        // 
        // lblProduct
        // 
        lblProduct.AutoSize = true;
        lblProduct.Font = new Font("Segoe UI", 15F);
        lblProduct.ForeColor = Color.FromArgb(190, 211, 232);
        lblProduct.Location = new Point(83, 347);
        lblProduct.Margin = new Padding(4, 0, 4, 0);
        lblProduct.Name = "lblProduct";
        lblProduct.Size = new Size(195, 28);
        lblProduct.TabIndex = 1;
        lblProduct.Text = "Management System";
        // 
        // lblTagline
        // 
        lblTagline.AutoSize = true;
        lblTagline.Font = new Font("Segoe UI", 11F);
        lblTagline.ForeColor = Color.FromArgb(205, 218, 232);
        lblTagline.Location = new Point(83, 467);
        lblTagline.Margin = new Padding(4, 0, 4, 0);
        lblTagline.Name = "lblTagline";
        lblTagline.Size = new Size(175, 40);
        lblTagline.TabIndex = 2;
        lblTagline.Text = "Track products, stock and\r\nactivity in one place.";
        // 
        // lblFeatures
        // 
        lblFeatures.AutoSize = true;
        lblFeatures.Font = new Font("Segoe UI", 10F);
        lblFeatures.ForeColor = Color.White;
        lblFeatures.Location = new Point(83, 575);
        lblFeatures.Margin = new Padding(4, 0, 4, 0);
        lblFeatures.Name = "lblFeatures";
        lblFeatures.Size = new Size(213, 57);
        lblFeatures.TabIndex = 3;
        lblFeatures.Text = "• Track products and stock levels\r\n• Spot low stock at a glance\r\n• Keep a complete activity history";
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(246, 248, 251);
        pnlForm.Controls.Add(lblTitle);
        pnlForm.Controls.Add(lblSubtitle);
        pnlForm.Controls.Add(lblUsername);
        pnlForm.Controls.Add(txtUsername);
        pnlForm.Controls.Add(lblPassword);
        pnlForm.Controls.Add(txtPassword);
        pnlForm.Controls.Add(btnSignIn);
        pnlForm.Controls.Add(linkRegister);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(600, 0);
        pnlForm.Margin = new Padding(4, 5, 4, 5);
        pnlForm.Name = "pnlForm";
        pnlForm.Size = new Size(494, 860);
        pnlForm.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
        lblTitle.Location = new Point(136, 217);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(237, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Welcome back";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10.5F);
        lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
        lblSubtitle.Location = new Point(141, 300);
        lblSubtitle.Margin = new Padding(4, 0, 4, 0);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(228, 19);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Sign in to your account to continue.";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblUsername.Location = new Point(143, 408);
        lblUsername.Margin = new Padding(4, 0, 4, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(76, 19);
        lblUsername.TabIndex = 2;
        lblUsername.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 11F);
        txtUsername.Location = new Point(143, 455);
        txtUsername.Margin = new Padding(4, 5, 4, 5);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(541, 27);
        txtUsername.TabIndex = 0;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblPassword.Location = new Point(143, 550);
        lblPassword.Margin = new Padding(4, 0, 4, 0);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(73, 19);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.Location = new Point(143, 597);
        txtPassword.Margin = new Padding(4, 5, 4, 5);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(541, 27);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnSignIn
        // 
        btnSignIn.BackColor = Color.FromArgb(37, 99, 235);
        btnSignIn.FlatAppearance.BorderSize = 0;
        btnSignIn.FlatStyle = FlatStyle.Flat;
        btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSignIn.ForeColor = Color.White;
        btnSignIn.Location = new Point(143, 708);
        btnSignIn.Margin = new Padding(4, 5, 4, 5);
        btnSignIn.Name = "btnSignIn";
        btnSignIn.Size = new Size(543, 75);
        btnSignIn.TabIndex = 2;
        btnSignIn.Text = "Sign In";
        btnSignIn.UseVisualStyleBackColor = false;
        btnSignIn.Click += btnSignIn_Click;
        // 
        // linkRegister
        // 
        linkRegister.AutoSize = true;
        linkRegister.Font = new Font("Segoe UI", 10F);
        linkRegister.LinkArea = new LinkArea(23, 14);
        linkRegister.Location = new Point(253, 825);
        linkRegister.Margin = new Padding(4, 0, 4, 0);
        linkRegister.Name = "linkRegister";
        linkRegister.Size = new Size(233, 23);
        linkRegister.TabIndex = 3;
        linkRegister.TabStop = true;
        linkRegister.Text = "Don't have an account? Register here.";
        linkRegister.UseCompatibleTextRendering = true;
        linkRegister.LinkClicked += linkRegister_LinkClicked;
        // 
        // SignInForm
        // 
        AcceptButton = btnSignIn;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 251);
        ClientSize = new Size(1094, 860);
        Controls.Add(pnlForm);
        Controls.Add(pnlBrand);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(793, 804);
        Name = "SignInForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inventory Management System";
        pnlBrand.ResumeLayout(false);
        pnlBrand.PerformLayout();
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        ResumeLayout(false);
    }
    private Panel pnlBrand, pnlForm; private Label lblBrand, lblProduct, lblTagline, lblFeatures, lblTitle, lblSubtitle, lblUsername, lblPassword; private TextBox txtUsername, txtPassword; private Button btnSignIn; private LinkLabel linkRegister;
}
