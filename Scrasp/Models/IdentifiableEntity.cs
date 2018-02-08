using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class IdentifiableEntity
    {
        private static int lastID;
        public int id { get; private set; }

        public IdentifiableEntity()
        {
            lastID++;
            id = lastID;
        }

    }
}