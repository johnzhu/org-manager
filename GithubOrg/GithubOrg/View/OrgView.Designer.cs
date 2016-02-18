namespace GithubOrg
{
    partial class OrgView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabRepo = new System.Windows.Forms.TabPage();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRepo.SuspendLayout();
            this.tabTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTeam);
            this.tabControl1.Controls.Add(this.tabRepo);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.comboBox3);
            this.tabUser.Controls.Add(this.dataGridView2);
            this.tabUser.Controls.Add(this.button2);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(507, 384);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabRepo
            // 
            this.tabRepo.Controls.Add(this.comboBox2);
            this.tabRepo.Controls.Add(this.dataGridViewRepo);
            this.tabRepo.Controls.Add(this.button1);
            this.tabRepo.Location = new System.Drawing.Point(4, 22);
            this.tabRepo.Name = "tabRepo";
            this.tabRepo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepo.Size = new System.Drawing.Size(507, 384);
            this.tabRepo.TabIndex = 1;
            this.tabRepo.Text = "Repositories";
            this.tabRepo.UseVisualStyleBackColor = true;
            // 
            // tabTeam
            // 
            this.tabTeam.Controls.Add(this.comboBox1);
            this.tabTeam.Controls.Add(this.dataGridView1);
            this.tabTeam.Location = new System.Drawing.Point(4, 22);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Size = new System.Drawing.Size(507, 384);
            this.tabTeam.TabIndex = 2;
            this.tabTeam.Text = "Team";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add to Team";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRepo
            // 
            this.dataGridViewRepo.AllowUserToAddRows = false;
            this.dataGridViewRepo.AllowUserToDeleteRows = false;
            this.dataGridViewRepo.AllowUserToOrderColumns = true;
            this.dataGridViewRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRepo.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.ReadOnly = true;
            this.dataGridViewRepo.Size = new System.Drawing.Size(501, 349);
            this.dataGridViewRepo.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(507, 349);
            this.dataGridView2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(193, 7);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(237, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // OrgView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "OrgView";
            this.Size = new System.Drawing.Size(521, 416);
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabRepo.ResumeLayout(false);
            this.tabTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRepo;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
