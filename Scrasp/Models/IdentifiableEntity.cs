using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class IdentifiableEntity
    {
        private static int lastID;
        private int _id;
        public int Id {
            get => _id;
            set{
                _id = value;
                lastID = _id;
            }
        }

        public IdentifiableEntity()
        {
            lastID++;
            _id = lastID;
        }

    }
}