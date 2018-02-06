using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Project : IdentifiableEntity
    {
        private string title;
        private string description;
        private string refRepo;
        private List<User> team;
        private List<Sprint> sprints;
    
        public Project(string title, string description, string refRepo, List<User> team, List<Sprint> sprints)
        {
            this.title = title;
            this.description = description;
            this.refRepo = refRepo;
            this.team = team;
            this.sprints = sprints;
        }

    }
}