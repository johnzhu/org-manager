using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit.Reactive.Clients;
using Octokit;
using Octokit.Reactive;

namespace GithubOrg
{
    public class Controller
    {
        public bool HasToken { get; internal set; }
        GitHubClient client = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));


        internal async void signIn(string username, string password)
        {
            var basicAuth = new Credentials(username, password); // NOTE: not real credentials
            client.Credentials = basicAuth;
            var orgs =  await client.Organization.GetAllForCurrent();
            var org = orgs[0];
            var members = await client.Organization.Team.GetAll(org.Name);


        }
    }
}
