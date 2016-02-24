namespace GithubOrg
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSignIn = new System.Windows.Forms.Button();
      this.lblError = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtToken = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(66, 58);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "User Name";
      // 
      // txtUser
      // 
      this.txtUser.Location = new System.Drawing.Point(171, 50);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(176, 20);
      this.txtUser.TabIndex = 1;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(171, 114);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(176, 20);
      this.txtPassword.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(66, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Password";
      // 
      // btnSignIn
      // 
      this.btnSignIn.Location = new System.Drawing.Point(192, 256);
      this.btnSignIn.Name = "btnSignIn";
      this.btnSignIn.Size = new System.Drawing.Size(75, 23);
      this.btnSignIn.TabIndex = 4;
      this.btnSignIn.Text = "OK";
      this.btnSignIn.UseVisualStyleBackColor = true;
      this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
      // 
      // lblError
      // 
      this.lblError.AutoSize = true;
      this.lblError.Location = new System.Drawing.Point(66, 209);
      this.lblError.Name = "lblError";
      this.lblError.Size = new System.Drawing.Size(29, 13);
      this.lblError.TabIndex = 5;
      this.lblError.Text = "Error";
      this.lblError.Visible = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(69, 168);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(88, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Or use API token";
      // 
      // txtToken
      // 
      this.txtToken.Location = new System.Drawing.Point(171, 168);
      this.txtToken.Name = "txtToken";
      this.txtToken.Size = new System.Drawing.Size(176, 20);
      this.txtToken.TabIndex = 3;
      // 
      // LoginPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Highlight;
      this.Controls.Add(this.txtToken);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lblError);
      this.Controls.Add(this.btnSignIn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUser);
      this.Controls.Add(this.label1);
      this.Name = "LoginPage";
      this.Size = new System.Drawing.Size(479, 320);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToken;
    }
}
