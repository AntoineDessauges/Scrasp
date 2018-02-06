using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Task : IdentifiableEntity
    {
        private string description;
        public enum States { finished, pending, on_hold }
        private States state;
        private User owner;
        private DateTime plannedStart;
        private int plannedDuration;

        public Task(string description, States state, User owner, DateTime plannedStart, int plannedDuration)
        {
            this.description = description;
            this.state = state;
            this.owner = owner;
            this.plannedStart = plannedStart;
            this.plannedDuration = plannedDuration;
        }
    }
}