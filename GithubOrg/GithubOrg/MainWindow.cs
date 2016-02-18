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
    public partial class MainWindow : Form
    {
        Controller _controller;
        public MainWindow( Controller controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!_controller.HasToken)
            {
                this.panel1.Controls.Add(new LoginPage(_controller));
            }
        }
    }
}
