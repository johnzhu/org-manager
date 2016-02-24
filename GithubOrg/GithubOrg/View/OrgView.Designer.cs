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
      this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PublicRepos = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fDescrption = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DefaultBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PushedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Repositories = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.tabControl1.MinimumSize = new System.Drawing.Size(200, 260);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(861, 320);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tabTeam
      // 
      this.tabTeam.BackColor = System.Drawing.Color.Transparent;
      this.tabTeam.Controls.Add(this.teamGridView);
      this.tabTeam.Location = new System.Drawing.Point(4, 22);
      this.tabTeam.Margin = new System.Windows.Forms.Padding(0);
      this.tabTeam.Name = "tabTeam";
      this.tabTeam.Size = new System.Drawing.Size(853, 294);
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
      this.teamGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fTeamName,
            this.Members,
            this.Repositories});
      this.teamGridView.Location = new System.Drawing.Point(0, 0);
      this.teamGridView.Name = "teamGridView";
      this.teamGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.teamGridView.Size = new System.Drawing.Size(852, 292);
      this.teamGridView.TabIndex = 0;
      this.teamGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // tabRepo
      // 
      this.tabRepo.BackColor = System.Drawing.Color.Gainsboro;
      this.tabRepo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.tabRepo.Controls.Add(this.repoGridView);
      this.tabRepo.Location = new System.Drawing.Point(4, 22);
      this.tabRepo.Name = "tabRepo";
      this.tabRepo.Padding = new System.Windows.Forms.Padding(3);
      this.tabRepo.Size = new System.Drawing.Size(853, 294);
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
      this.repoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.fDescrption,
            this.fLanguage,
            this.DefaultBranch,
            this.CreateAt,
            this.PushedAt});
      this.repoGridView.Location = new System.Drawing.Point(3, 0);
      this.repoGridView.Name = "repoGridView";
      this.repoGridView.ReadOnly = true;
      this.repoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.repoGridView.Size = new System.Drawing.Size(852, 292);
      this.repoGridView.TabIndex = 1;
      // 
      // tabUser
      // 
      this.tabUser.Controls.Add(this.userGridView);
      this.tabUser.Location = new System.Drawing.Point(4, 22);
      this.tabUser.Name = "tabUser";
      this.tabUser.Padding = new System.Windows.Forms.Padding(3);
      this.tabUser.Size = new System.Drawing.Size(853, 294);
      this.tabUser.TabIndex = 0;
      this.tabUser.Text = "Users";
      this.tabUser.UseVisualStyleBackColor = true;
      // 
      // userGridView
      // 
      this.userGridView.AllowUserToAddRows = false;
      this.userGridView.AllowUserToDeleteRows = false;
      this.userGridView.AllowUserToOrderColumns = true;
      this.userGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.fUserName,
            this.PublicRepos});
      this.userGridView.Location = new System.Drawing.Point(3, 0);
      this.userGridView.Name = "userGridView";
      this.userGridView.ReadOnly = true;
      this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.userGridView.Size = new System.Drawing.Size(852, 292);
      this.userGridView.TabIndex = 2;
      // 
      // btnAddToTeam
      // 
      this.btnAddToTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAddToTeam.Location = new System.Drawing.Point(85, 332);
      this.btnAddToTeam.Name = "btnAddToTeam";
      this.btnAddToTeam.Size = new System.Drawing.Size(101, 23);
      this.btnAddToTeam.TabIndex = 1;
      this.btnAddToTeam.Text = "Add to Team";
      this.btnAddToTeam.UseVisualStyleBackColor = true;
      this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
      // 
      // teamList
      // 
      this.teamList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.teamList.DisplayMember = "Name";
      this.teamList.FormattingEnabled = true;
      this.teamList.Location = new System.Drawing.Point(222, 334);
      this.teamList.Name = "teamList";
      this.teamList.Size = new System.Drawing.Size(229, 21);
      this.teamList.TabIndex = 3;
      this.teamList.SelectedValueChanged += new System.EventHandler(this.teamList_SelectedValueChanged);
      // 
      // Login
      // 
      this.Login.DataPropertyName = "Login";
      this.Login.HeaderText = "Login";
      this.Login.Name = "Login";
      this.Login.ReadOnly = true;
      // 
      // fUserName
      // 
      this.fUserName.DataPropertyName = "Name";
      this.fUserName.HeaderText = "Name";
      this.fUserName.Name = "fUserName";
      this.fUserName.ReadOnly = true;
      // 
      // PublicRepos
      // 
      this.PublicRepos.DataPropertyName = "PublicRepos";
      this.PublicRepos.HeaderText = "PublicRepos";
      this.PublicRepos.Name = "PublicRepos";
      this.PublicRepos.ReadOnly = true;
      // 
      // fName
      // 
      this.fName.DataPropertyName = "Name";
      this.fName.HeaderText = "Name";
      this.fName.Name = "fName";
      this.fName.ReadOnly = true;
      // 
      // fDescrption
      // 
      this.fDescrption.DataPropertyName = "Description";
      this.fDescrption.HeaderText = "Description";
      this.fDescrption.Name = "fDescrption";
      this.fDescrption.ReadOnly = true;
      // 
      // fLanguage
      // 
      this.fLanguage.DataPropertyName = "Language";
      this.fLanguage.HeaderText = "Language";
      this.fLanguage.Name = "fLanguage";
      this.fLanguage.ReadOnly = true;
      // 
      // DefaultBranch
      // 
      this.DefaultBranch.DataPropertyName = "DefaultBranch";
      this.DefaultBranch.HeaderText = "DefaultBranch";
      this.DefaultBranch.Name = "DefaultBranch";
      this.DefaultBranch.ReadOnly = true;
      // 
      // CreateAt
      // 
      this.CreateAt.DataPropertyName = "CreatedAt";
      this.CreateAt.HeaderText = "CreatedAt";
      this.CreateAt.Name = "CreateAt";
      this.CreateAt.ReadOnly = true;
      // 
      // PushedAt
      // 
      this.PushedAt.DataPropertyName = "PushedAt";
      this.PushedAt.HeaderText = "PushedAt";
      this.PushedAt.Name = "PushedAt";
      this.PushedAt.ReadOnly = true;
      // 
      // fTeamName
      // 
      this.fTeamName.DataPropertyName = "Name";
      this.fTeamName.HeaderText = "Name";
      this.fTeamName.Name = "fTeamName";
      this.fTeamName.ReadOnly = true;
      // 
      // Members
      // 
      this.Members.DataPropertyName = "Members";
      this.Members.HeaderText = "Members";
      this.Members.Name = "Members";
      this.Members.ReadOnly = true;
      // 
      // Repositories
      // 
      this.Repositories.DataPropertyName = "Repositories";
      this.Repositories.HeaderText = "Repositories";
      this.Repositories.Name = "Repositories";
      this.Repositories.ReadOnly = true;
      // 
      // OrgView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.Highlight;
      this.Controls.Add(this.teamList);
      this.Controls.Add(this.btnAddToTeam);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "OrgView";
      this.Size = new System.Drawing.Size(861, 372);
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
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRepo;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.DataGridView teamGridView;
        private System.Windows.Forms.DataGridView repoGridView;
        private System.Windows.Forms.DataGridView userGridView;
    private System.Windows.Forms.ComboBox teamList;
    private System.Windows.Forms.Button btnAddToTeam;
    private System.DirectoryServices.DirectoryEntry directoryEntry1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Login;
    private System.Windows.Forms.DataGridViewTextBoxColumn fUserName;
    private System.Windows.Forms.DataGridViewTextBoxColumn PublicRepos;
    private System.Windows.Forms.DataGridViewTextBoxColumn fName;
    private System.Windows.Forms.DataGridViewTextBoxColumn fDescrption;
    private System.Windows.Forms.DataGridViewTextBoxColumn fLanguage;
    private System.Windows.Forms.DataGridViewTextBoxColumn DefaultBranch;
    private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
    private System.Windows.Forms.DataGridViewTextBoxColumn PushedAt;
    private System.Windows.Forms.DataGridViewTextBoxColumn fTeamName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Members;
    private System.Windows.Forms.DataGridViewTextBoxColumn Repositories;
  }
}
