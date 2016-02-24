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
    public List<User> Users { get; private set; }
    public List<TeamViewModel> Teams { get; private set; }
    public IReadOnlyList<Repository> Repos { get; internal set; }
    public Action onUpdateTeam { get; internal set; }

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
      var repo = await _client.Organization.Team.GetAllRepositories(t.Id);
      team.Users = user;
      team.Repos = repo;
      return team;
    }
    private Task<User> initUser(User u)
    {
      var user  =  _client.User.Get(u.Login);
      return user;
    }
    public async void onOrgReady(string org)
    {
      try
      {
        var teams = await _client.Organization.Team.GetAll(org);
        var tt= await Task.WhenAll(teams.Select(t => initTeam(t)));
        Teams = tt.ToList();
        var users = await _client.Organization.Member.GetAll(org);
        var uu = await Task.WhenAll(users.Select( u => _client.User.Get(u.Login)));
        Users = uu.ToList();
        Repos = await _client.Repository.GetAllForOrg(org);
        onDataReady(this, null);
      }
      catch (Exception ex)
      {
        Console.Out.Write(ex.Message);
      }

    }
    public async void reloadTeam(TeamViewModel team)
    {
      var user = await _client.Organization.Team.GetAllMembers(team.team.Id);
      var repo = await _client.Organization.Team.GetAllRepositories(team.team.Id);
      team.Users = user;
      team.Repos = repo;
      onUpdateTeam();
    }

    internal void doAddUser(List<User> userList, Team team)
    {
      Parallel.ForEach(userList, (x)=>_client.Organization.Team.AddMembership(team.Id, x.Login));
    }

    internal void doAddRepo(List<Repository> repoList, Team team)
    {
      throw new NotImplementedException();
    }
  }
}
