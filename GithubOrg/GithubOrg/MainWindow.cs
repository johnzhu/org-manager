using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubOrg
{
  static public class InvokeExt
  {
    public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
    {
      // If the invoke is not required, then invoke here and get out.
      if (!sync.InvokeRequired)
      {
        // Execute action.
        action();

        // Get out.
        return;
      }

      // Marshal to the required context.
      sync.Invoke(action, new object[] { });
    }
  }
  public partial class MainWindow : Form
    {
        Controller _controller;
        public MainWindow( Controller controller)
        {
            _controller = controller;
            _controller.OrgSelectedHandler = onOrgSet;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
      panel1.AutoSize = true;
      panel1.Dock = DockStyle.Fill;
      if (!_controller.HasToken)
            {
                this.panel1.Controls.Add(new LoginPage(_controller));
            }
        }

        public void onOrgSet(object sender, EventArgs e)
        {
            if (_controller.orgs.Orgs.Count == 1)
            {
                _controller.orgs.org = _controller.orgs.Orgs[0];
            }
      this.SynchronizedInvoke(() =>
      {
        this.panel1.Controls.Clear();
        this.panel1.Controls.Add(new OrgView(_controller, _controller.userTeamModel));
      });
        }
    }
}
