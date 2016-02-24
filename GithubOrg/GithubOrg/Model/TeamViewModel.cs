using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace GithubOrg.Model
{
  public class TeamViewModel
  {
    internal IReadOnlyList<User> Users;
    internal IReadOnlyList<Repository> Repos;
    public Team team {
      get; }
    public string Name {  get { return team.Name; } }
    public int Members { get { return Users == null? 0: Users.Count; } }
    public int Repositories { get { return Repos == null ? 0 : Repos.Count; } }

    public TeamViewModel(Team t)
    {
      this.team = t;
    }
  }
}
