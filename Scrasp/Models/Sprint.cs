using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Sprint : IdentifiableEntity
    {
        private int number;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private List<Story> stories;

        public Sprint(int number, string description, DateTime startDate, DateTime endDate, List<Story> stories)
        {
            this.number = number;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.stories = stories;
        }

    }
}