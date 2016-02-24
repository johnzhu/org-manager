using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit.Reactive.Clients;
using Octokit;
using Octokit.Reactive;
using GithubOrg.Model;

namespace GithubOrg
{
  public class Controller
  {
    public bool HasToken { get; internal set; }
    GitHubClient client = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
    public EventHandler<string> authErrorHandler;
    public EventHandler OrgSelectedHandler;
    ObservableGitHubClient _client;
    public UserOrganizations orgs { get; private set; }
    public DataModel userTeamModel { get; private set; }
    public Controller()
    {
      _client = new ObservableGitHubClient(client);
      orgs = new UserOrganizations();
      userTeamModel = new DataModel(client);
    }
    internal void signIn(string username, string password, string token)
    {
      var basicAuth = String.IsNullOrEmpty(token) ? new Credentials(username, password) : new Credentials(token);
      client.Credentials = basicAuth;
      orgs.Orgs.Clear();
      _client.Organization.GetAllForCurrent().Subscribe<Organization>(
          o => addOrg(o),
          ex =>
          {
            if (authErrorHandler != null) { authErrorHandler(this, ex.Message); }
          },
          () => setOrg()
          );
      ;


    }

    private void setOrg()
    {
      OrgSelectedHandler(this, new EventArgs());

    }

    private void addOrg(Organization o)
    {
      orgs.Orgs.Add(o);
    }
  }
}
