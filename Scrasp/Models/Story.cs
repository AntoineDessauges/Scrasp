using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Story : IdentifiableEntity
    {
        private string description;
        private string refName;
        private string actor;
        public enum Types { epic, normal }
        private Types type;
        public enum States { finished, pending, on_hold }
        private States state;
        private int points;
        private List<Task> tasks;

        public Story(string description, string refName, string actor, Types type, States state, int points, List<Task> tasks)
        {
            this.description = description;
            this.refName = refName;
            this.actor = actor;
            this.type = type;
            this.state = state;
            this.points = points;
            this.tasks = tasks;
        }
    }
}