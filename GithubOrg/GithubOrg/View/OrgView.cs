using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubOrg
{
    public partial class OrgView : UserControl
    {
        Controller _controller;
        public OrgView(Controller controller)
        {
            _controller = controller;
            InitializeComponent();
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

        private void OrgView_Load(object sender, EventArgs e)
        {
            _controller.loadTeam();
        }
    }
}
