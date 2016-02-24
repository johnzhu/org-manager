using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GithubOrg.Model;

namespace GithubOrg
{
  public partial class OrgView : UserControl
  {
    Controller _controller;
    DataModel _userModel;
    public OrgView(Controller controller, DataModel userModel)
    {
      InitializeComponent();
      _userModel = userModel;
      _controller = controller;
      _userModel.onDataReady += this.onUpdate;
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void tabControl1_Selected(object sender, TabControlEventArgs e)
    {

    }

    private void dataGridViewRepo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void onUpdate(object sender, EventArgs e)
    {
      teamList.DataSource = _userModel.Teams;
      teamList.DisplayMember = "Name";
      teamList.Select(0,1);
      this.repoGridView.DataSource = _userModel.Repos;
      this.userGridView.DataSource = _userModel.Users;//.Select(u=>new UserViewModel(u)).ToList();
      this.teamGridView.DataSource = _userModel.Teams[0].Users;
      foreach (DataGridViewColumn column in repoGridView.Columns)
      {
        repoGridView.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
      }
      foreach (DataGridViewColumn column in userGridView.Columns)
      {
        userGridView.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
      }
      foreach (DataGridViewColumn column in teamGridView.Columns)
      {
        teamGridView.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
      }

      this.Invalidate();
      this.Update();
      this.Refresh();
    }
    private void OrgView_Load(object sender, EventArgs org)
    {
      this.Dock = DockStyle.Fill;
      this.AutoSize = true;
      this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
      _userModel.onOrgReady(_controller.orgs.org.Login);

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void teamList_SelectedValueChanged(object sender, EventArgs e)
    {
      var sel = teamList.SelectedItem as TeamViewModel;
      teamGridView.DataSource = sel.Users;
    }

    private void btnAddToTeam_Click(object sender, EventArgs e)
    {
      var ta = tabControl1.SelectedTab;

    }
  }
}
