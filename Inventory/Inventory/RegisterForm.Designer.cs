#nullable disable
namespace inventory;
partial class RegisterForm
{
 private System.ComponentModel.IContainer components = null;
 protected override void Dispose(bool disposing) { if(disposing && components != null) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        pnlBrand = new Panel();
        lblBrand = new Label();
        lblProduct = new Label();
        lblTagline = new Label();
        pnlForm = new Panel();
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblFullName = new Label();
        txtFullName = new TextBox();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        lblConfirm = new Label();
        txtConfirm = new TextBox();
        btnRegister = new Button();
        linkSignIn = new LinkLabel();
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
        pnlBrand.Dock = DockStyle.Left;
        pnlBrand.Location = new Point(0, 0);
        pnlBrand.Margin = new Padding(4, 5, 4, 5);
        pnlBrand.Name = "pnlBrand";
        pnlBrand.Size = new Size(514, 860);
        pnlBrand.TabIndex = 1;
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        lblBrand.ForeColor = Color.White;
        lblBrand.Location = new Point(64, 317);
        lblBrand.Margin = new Padding(4, 0, 4, 0);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(197, 51);
        lblBrand.TabIndex = 0;
        lblBrand.Text = "Inventory";
        // 
        // lblProduct
        // 
        lblProduct.AutoSize = true;
        lblProduct.Font = new Font("Segoe UI", 14F);
        lblProduct.ForeColor = Color.FromArgb(190, 211, 232);
        lblProduct.Location = new Point(69, 400);
        lblProduct.Margin = new Padding(4, 0, 4, 0);
        lblProduct.Name = "lblProduct";
        lblProduct.Size = new Size(187, 25);
        lblProduct.TabIndex = 1;
        lblProduct.Text = "Management System";
        // 
        // lblTagline
        // 
        lblTagline.AutoSize = true;
        lblTagline.Font = new Font("Segoe UI", 10.5F);
        lblTagline.ForeColor = Color.White;
        lblTagline.Location = new Point(69, 500);
        lblTagline.Margin = new Padding(4, 0, 4, 0);
        lblTagline.Name = "lblTagline";
        lblTagline.Size = new Size(224, 19);
        lblTagline.TabIndex = 2;
        lblTagline.Text = "Create your account to get started.";
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(246, 248, 251);
        pnlForm.Controls.Add(lblTitle);
        pnlForm.Controls.Add(lblSubtitle);
        pnlForm.Controls.Add(lblFullName);
        pnlForm.Controls.Add(txtFullName);
        pnlForm.Controls.Add(lblUsername);
        pnlForm.Controls.Add(txtUsername);
        pnlForm.Controls.Add(lblPassword);
        pnlForm.Controls.Add(txtPassword);
        pnlForm.Controls.Add(lblConfirm);
        pnlForm.Controls.Add(txtConfirm);
        pnlForm.Controls.Add(btnRegister);
        pnlForm.Controls.Add(linkSignIn);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(514, 0);
        pnlForm.Margin = new Padding(4, 5, 4, 5);
        pnlForm.Name = "pnlForm";
        pnlForm.Size = new Size(580, 860);
        pnlForm.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
        lblTitle.Location = new Point(107, 80);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(313, 42);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Create your account";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10F);
        lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
        lblSubtitle.Location = new Point(113, 157);
        lblSubtitle.Margin = new Padding(4, 0, 4, 0);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(206, 19);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Fill in your details to get started.";
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblFullName.Location = new Point(114, 242);
        lblFullName.Margin = new Padding(4, 0, 4, 0);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new Size(69, 17);
        lblFullName.TabIndex = 2;
        lblFullName.Text = "Full name";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 10.5F);
        txtFullName.Location = new Point(114, 283);
        txtFullName.Margin = new Padding(4, 5, 4, 5);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(598, 26);
        txtFullName.TabIndex = 0;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblUsername.Location = new Point(114, 358);
        lblUsername.Margin = new Padding(4, 0, 4, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(69, 17);
        lblUsername.TabIndex = 3;
        lblUsername.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 10.5F);
        txtUsername.Location = new Point(114, 400);
        txtUsername.Margin = new Padding(4, 5, 4, 5);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(598, 26);
        txtUsername.TabIndex = 1;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblPassword.Location = new Point(114, 475);
        lblPassword.Margin = new Padding(4, 0, 4, 0);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(66, 17);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 10.5F);
        txtPassword.Location = new Point(114, 517);
        txtPassword.Margin = new Padding(4, 5, 4, 5);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(598, 26);
        txtPassword.TabIndex = 2;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblConfirm
        // 
        lblConfirm.AutoSize = true;
        lblConfirm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblConfirm.Location = new Point(114, 592);
        lblConfirm.Margin = new Padding(4, 0, 4, 0);
        lblConfirm.Name = "lblConfirm";
        lblConfirm.Size = new Size(120, 17);
        lblConfirm.TabIndex = 5;
        lblConfirm.Text = "Confirm password";
        // 
        // txtConfirm
        // 
        txtConfirm.Font = new Font("Segoe UI", 10.5F);
        txtConfirm.Location = new Point(114, 633);
        txtConfirm.Margin = new Padding(4, 5, 4, 5);
        txtConfirm.Name = "txtConfirm";
        txtConfirm.Size = new Size(598, 26);
        txtConfirm.TabIndex = 3;
        txtConfirm.UseSystemPasswordChar = true;
        // 
        // btnRegister
        // 
        btnRegister.BackColor = Color.FromArgb(37, 99, 235);
        btnRegister.FlatAppearance.BorderSize = 0;
        btnRegister.FlatStyle = FlatStyle.Flat;
        btnRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        btnRegister.ForeColor = Color.White;
        btnRegister.Location = new Point(114, 725);
        btnRegister.Margin = new Padding(4, 5, 4, 5);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(600, 72);
        btnRegister.TabIndex = 4;
        btnRegister.Text = "Create Account";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // linkSignIn
        // 
        linkSignIn.AutoSize = true;
        linkSignIn.Font = new Font("Segoe UI", 10F);
        linkSignIn.LinkArea = new LinkArea(25, 13);
        linkSignIn.Location = new Point(271, 833);
        linkSignIn.Margin = new Padding(4, 0, 4, 0);
        linkSignIn.Name = "linkSignIn";
        linkSignIn.Size = new Size(238, 23);
        linkSignIn.TabIndex = 5;
        linkSignIn.TabStop = true;
        linkSignIn.Text = "Already have an account? Sign in here.";
        linkSignIn.UseCompatibleTextRendering = true;
        linkSignIn.LinkClicked += linkSignIn_LinkClicked;
        // 
        // RegisterForm
        // 
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 251);
        ClientSize = new Size(1094, 860);
        Controls.Add(pnlForm);
        Controls.Add(pnlBrand);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(793, 904);
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Register";
        pnlBrand.ResumeLayout(false);
        pnlBrand.PerformLayout();
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        ResumeLayout(false);
    }
    private Panel pnlBrand,pnlForm; private Label lblBrand,lblProduct,lblTagline,lblTitle,lblSubtitle,lblFullName,lblUsername,lblPassword,lblConfirm; private TextBox txtFullName,txtUsername,txtPassword,txtConfirm; private Button btnRegister; private LinkLabel linkSignIn;
}
