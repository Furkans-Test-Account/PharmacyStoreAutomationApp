namespace GorselProgProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            buttonLogin = new Button();
            labelUser = new Label();
            labelPassword = new Label();
            labelH1 = new Label();
            panel1 = new Panel();
            labelDate = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            linkLabelReset = new LinkLabel();
            labelH2 = new Label();
            labelVersion = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(113, 259);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelUser.Location = new Point(21, 161);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(62, 15);
            labelUser.TabIndex = 2;
            labelUser.Text = "UserName";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelPassword.Location = new Point(21, 215);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // labelH1
            // 
            labelH1.AutoSize = true;
            labelH1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelH1.Location = new Point(78, 37);
            labelH1.Name = "labelH1";
            labelH1.Size = new Size(70, 30);
            labelH1.TabIndex = 4;
            labelH1.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(316, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 449);
            panel1.TabIndex = 5;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelDate.Location = new Point(78, 380);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 0;
            labelDate.Text = "date";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(103, 161);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(100, 23);
            textBoxUser.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(103, 215);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // linkLabelReset
            // 
            linkLabelReset.AutoSize = true;
            linkLabelReset.Location = new Point(88, 326);
            linkLabelReset.Name = "linkLabelReset";
            linkLabelReset.Size = new Size(60, 15);
            linkLabelReset.TabIndex = 8;
            linkLabelReset.TabStop = true;
            linkLabelReset.Text = "linkLabel1";
            linkLabelReset.LinkClicked += linkLabelReset_LinkClicked;
            // 
            // labelH2
            // 
            labelH2.AutoSize = true;
            labelH2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelH2.Location = new Point(36, 96);
            labelH2.Name = "labelH2";
            labelH2.Size = new Size(43, 17);
            labelH2.TabIndex = 9;
            labelH2.Text = "label3";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelVersion.Location = new Point(233, 426);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(44, 15);
            labelVersion.TabIndex = 10;
            labelVersion.Text = "version";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVersion);
            Controls.Add(labelDate);
            Controls.Add(labelH2);
            Controls.Add(linkLabelReset);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(panel1);
            Controls.Add(labelH1);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(buttonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Pharmacy Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelUser;
        private Label labelPassword;
        private Label labelH1;
        private Panel panel1;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelReset;
        private Label labelDate;
        private Label labelH2;
        private Label labelVersion;
    }
}
