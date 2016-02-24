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
    DataGridViewCellStyle defaultStyle;
    Controller _controller;
    DataModel _userModel;
    public OrgView(Controller controller, DataModel userModel)
    {
      InitializeComponent();
      this.repoGridView.AutoGenerateColumns = false;
      this.userGridView.AutoGenerateColumns = false;
      this.teamGridView.AutoGenerateColumns = false;
      _userModel = userModel;
      _controller = controller;
      _userModel.onDataReady += this.onUpdate;
      _userModel.onUpdateTeam += updateSelections;
    }
    private void onUpdate(object sender, EventArgs e)
    {
      teamList.DataSource = _userModel.Teams;
      teamList.DisplayMember = "Name";
      teamList.Select(0,1);
      this.repoGridView.DataSource = _userModel.Repos;
      this.userGridView.DataSource = _userModel.Users;
      this.teamGridView.DataSource = _userModel.Teams;
      foreach (DataGridViewColumn column in repoGridView.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Automatic;
      }
      foreach (DataGridViewColumn column in userGridView.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Automatic;
      }
      foreach (DataGridViewColumn column in teamGridView.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Automatic;
      }
      defaultStyle = teamGridView.Rows[0].DefaultCellStyle.Clone();

      this.Invalidate();
      this.Update();
      this.Refresh();
    }
    private void OrgView_Load(object sender, EventArgs org)
    {
      _userModel.onOrgReady(_controller.orgs.org.Login);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void teamList_SelectedValueChanged(object sender, EventArgs e)
    {
      updateSelections();
    }
  public void updateSelections()
    {
      this.SynchronizedInvoke(() =>
      {
        var sel = teamList.SelectedItem as TeamViewModel;
        if (sel != null)
        {
          foreach (DataGridViewRow row in userGridView.Rows)
          {
            var user = row.DataBoundItem as Octokit.User;
            if (sel.Users.Any(u => u.Id == user.Id))
            {
              row.DefaultCellStyle.BackColor = SystemColors.GrayText;
              row.DefaultCellStyle.SelectionForeColor = Color.Red;
            }
            else
            {
              row.DefaultCellStyle.BackColor = defaultStyle.BackColor;
              row.DefaultCellStyle.SelectionForeColor = defaultStyle.SelectionForeColor;
            }
          }
          foreach (DataGridViewRow row in repoGridView.Rows)
          {
            var repo = row.DataBoundItem as Octokit.Repository;
            if (sel.Repos.Any(u => u.Id == repo.Id))
            {
              row.DefaultCellStyle.BackColor = SystemColors.GrayText;
              row.DefaultCellStyle.SelectionForeColor = Color.Red;
            }
            else
            {
              row.DefaultCellStyle.BackColor = defaultStyle.BackColor;
              row.DefaultCellStyle.SelectionForeColor = defaultStyle.SelectionForeColor;
            }
          }
          this.Invalidate();
          this.Update();
          this.Refresh();
        }
      });
    }
  private void btnAddToTeam_Click(object sender, EventArgs e)
    {
      var ta = tabControl1.SelectedTab;
      var sel = this.teamList.SelectedItem as TeamViewModel;
      var team = sel.team;
      switch(ta.Name)
      {
        case "tabUser":
          var userList = userGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Octokit.User).ToList();
          _userModel.doAddUser(userList, team);
          break;
        case "tabRepo":
          var repoList = repoGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Octokit.Repository).ToList();
          _userModel.doAddRepo(repoList, team);
          break;
      }
      System.Threading.Thread.Sleep(500);
      _userModel.reloadTeam(sel);
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
