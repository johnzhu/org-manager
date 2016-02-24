using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
namespace GithubOrg.Model
{
  public class UserViewModel
  {
    private User user;
    public string Login { get { return user.Login; } }
    public string Name { get { return user.Name; } }
    public UserViewModel(User u)
    {
      user = u;
    }
  }
}
