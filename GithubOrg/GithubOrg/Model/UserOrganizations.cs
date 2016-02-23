using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubOrg.Model
{
    public class UserOrganizations
    {
        public UserOrganizations()
        {
            Orgs = new List<Organization>();
        }
        public List<Organization> Orgs {
            get; set;
        }
        public Organization org { get; set; }
    }
}
