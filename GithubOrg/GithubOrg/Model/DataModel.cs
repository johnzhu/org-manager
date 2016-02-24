using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

using Octokit.Reactive;

namespace GithubOrg.Model
{
  public class DataModel
  {
    public List<UserViewModel> Users { get; private set; }
    public List<TeamViewModel> Teams { get; private set; }
    public IReadOnlyList<Repository> Repos { get; internal set; }

    public EventHandler onDataReady;
    GitHubClient _client;
    public DataModel (GitHubClient client)
    {
      _client = client;
    }
    private async Task<TeamViewModel> initTeam(Team t)
    {
      
      var team = new TeamViewModel(t);
      var user = await _client.Organization.Team.GetAllMembers(t.Id);
      team.Users = user;
      return team;
    }
    private async Task<UserViewModel> initUser(User u)
    {
      var user  = await _client.User.Get(u.Login);
      return new UserViewModel(user);
    }
    public async void onOrgReady(string org)
    {
      try
      {
        var teams = await _client.Organization.Team.GetAll(org);
        var tt= await Task.WhenAll(teams.Select(t => initTeam(t)));
        Teams = tt.ToList();
        var users = await _client.Organization.Member.GetAll(org);
        var uu = await Task.WhenAll(users.Select( u =>initUser(u)));
        Users = uu.ToList();
        Repos = await _client.Repository.GetAllForOrg(org);
        onDataReady(this, null);
      }
      catch (Exception ex)
      {
        Console.Out.Write(ex.Message);
      }

    }
    
  }
}
