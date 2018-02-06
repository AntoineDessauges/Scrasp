using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Task : IdentifiableEntity
    {
        public string Description { get; private set; }
        public enum States { finished, pending, on_hold }
        private States state;
        private User owner;
        private DateTime plannedStart;
        private int plannedDuration;

        public Task(string description, States state, User owner, DateTime plannedStart, int plannedDuration)
        {
            Description = description;
            this.state = state;
            this.owner = owner;
            this.plannedStart = plannedStart;
            this.plannedDuration = plannedDuration;
        }
    }
}