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
      this.tabTeam = new System.Windows.Forms.TabPage();
      this.teamGridView = new System.Windows.Forms.DataGridView();
      this.tabRepo = new System.Windows.Forms.TabPage();
      this.repoGridView = new System.Windows.Forms.DataGridView();
      this.tabUser = new System.Windows.Forms.TabPage();
      this.userGridView = new System.Windows.Forms.DataGridView();
      this.btnAddToTeam = new System.Windows.Forms.Button();
      this.teamList = new System.Windows.Forms.ComboBox();
      this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
      this.tabControl1.SuspendLayout();
      this.tabTeam.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).BeginInit();
      this.tabRepo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.repoGridView)).BeginInit();
      this.tabUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
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
      this.tabControl1.MinimumSize = new System.Drawing.Size(300, 400);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(839, 704);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
      // 
      // tabTeam
      // 
      this.tabTeam.BackColor = System.Drawing.Color.Transparent;
      this.tabTeam.Controls.Add(this.teamGridView);
      this.tabTeam.Location = new System.Drawing.Point(4, 29);
      this.tabTeam.Margin = new System.Windows.Forms.Padding(0);
      this.tabTeam.Name = "tabTeam";
      this.tabTeam.Size = new System.Drawing.Size(831, 671);
      this.tabTeam.TabIndex = 2;
      this.tabTeam.Text = "Team";
      // 
      // teamGridView
      // 
      this.teamGridView.AllowUserToAddRows = false;
      this.teamGridView.AllowUserToDeleteRows = false;
      this.teamGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.teamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.teamGridView.Location = new System.Drawing.Point(0, 0);
      this.teamGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.teamGridView.Name = "teamGridView";
      this.teamGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.teamGridView.Size = new System.Drawing.Size(831, 671);
      this.teamGridView.TabIndex = 0;
      this.teamGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // tabRepo
      // 
      this.tabRepo.BackColor = System.Drawing.Color.Gainsboro;
      this.tabRepo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.tabRepo.Controls.Add(this.repoGridView);
      this.tabRepo.Location = new System.Drawing.Point(4, 29);
      this.tabRepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabRepo.Name = "tabRepo";
      this.tabRepo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabRepo.Size = new System.Drawing.Size(831, 671);
      this.tabRepo.TabIndex = 1;
      this.tabRepo.Text = "Repositories";
      // 
      // repoGridView
      // 
      this.repoGridView.AllowUserToAddRows = false;
      this.repoGridView.AllowUserToDeleteRows = false;
      this.repoGridView.AllowUserToOrderColumns = true;
      this.repoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.repoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.repoGridView.Location = new System.Drawing.Point(4, 0);
      this.repoGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.repoGridView.Name = "repoGridView";
      this.repoGridView.ReadOnly = true;
      this.repoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.repoGridView.Size = new System.Drawing.Size(823, 671);
      this.repoGridView.TabIndex = 1;
      this.repoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepo_CellContentClick);
      // 
      // tabUser
      // 
      this.tabUser.Controls.Add(this.userGridView);
      this.tabUser.Location = new System.Drawing.Point(4, 29);
      this.tabUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabUser.Name = "tabUser";
      this.tabUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabUser.Size = new System.Drawing.Size(831, 671);
      this.tabUser.TabIndex = 0;
      this.tabUser.Text = "Users";
      this.tabUser.UseVisualStyleBackColor = true;
      // 
      // userGridView
      // 
      this.userGridView.AllowUserToAddRows = false;
      this.userGridView.AllowUserToDeleteRows = false;
      this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.userGridView.Location = new System.Drawing.Point(0, 0);
      this.userGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.userGridView.Name = "userGridView";
      this.userGridView.ReadOnly = true;
      this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.userGridView.Size = new System.Drawing.Size(835, 671);
      this.userGridView.TabIndex = 2;
      this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      // 
      // btnAddToTeam
      // 
      this.btnAddToTeam.Location = new System.Drawing.Point(162, 710);
      this.btnAddToTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnAddToTeam.Name = "btnAddToTeam";
      this.btnAddToTeam.Size = new System.Drawing.Size(152, 35);
      this.btnAddToTeam.TabIndex = 1;
      this.btnAddToTeam.Text = "Add to Team";
      this.btnAddToTeam.UseVisualStyleBackColor = true;
      this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
      // 
      // teamList
      // 
      this.teamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.teamList.DisplayMember = "Name";
      this.teamList.FormattingEnabled = true;
      this.teamList.Location = new System.Drawing.Point(333, 714);
      this.teamList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.teamList.Name = "teamList";
      this.teamList.Size = new System.Drawing.Size(342, 28);
      this.teamList.TabIndex = 3;
      this.teamList.SelectedValueChanged += new System.EventHandler(this.teamList_SelectedValueChanged);
      // 
      // OrgView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.teamList);
      this.Controls.Add(this.btnAddToTeam);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "OrgView";
      this.Size = new System.Drawing.Size(861, 768);
      this.Load += new System.EventHandler(this.OrgView_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabTeam.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).EndInit();
      this.tabRepo.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.repoGridView)).EndInit();
      this.tabUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRepo;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.DataGridView teamGridView;
        private System.Windows.Forms.DataGridView repoGridView;
        private System.Windows.Forms.DataGridView userGridView;
    private System.Windows.Forms.ComboBox teamList;
    private System.Windows.Forms.Button btnAddToTeam;
    private System.DirectoryServices.DirectoryEntry directoryEntry1;
  }
}
