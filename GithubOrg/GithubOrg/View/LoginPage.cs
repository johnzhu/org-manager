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
    public partial class LoginPage : UserControl
    {
        private Controller _controller;

        public LoginPage(Controller _controller)
        {
            this._controller = _controller;
            _controller.authErrorHandler = onAuthenticationError;
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            _controller.signIn(txtUser.Text, txtPassword.Text, txtToken.Text);
        }
        public void onAuthenticationError(object sender, string e)
        {
            lblError.Visible = true;
            lblError.Text = e;
        }
    }
}
