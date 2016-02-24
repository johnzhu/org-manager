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
    private Team t;
    public string Name { get { return t.Name; } }

    public TeamViewModel(Team t)
    {
      this.t = t;
    }
  }
}
