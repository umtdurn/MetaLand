﻿namespace MetaLand.UI
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNickName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(91, 129);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Kullanıcı Adı";
            txtNickName.Size = new Size(273, 23);
            txtNickName.TabIndex = 0;
            txtNickName.Tag = "";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(91, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(273, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Tag = "";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(161, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 49);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 52);
            label1.Name = "label1";
            label1.Size = new Size(335, 25);
            label1.TabIndex = 3;
            label1.Text = "Welcome Back METALAND";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNickName);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNickName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
    }
}