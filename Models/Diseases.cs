using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Models
{
    class Diseases:RealmObject
    {
        public string name { get; set; }
        public int percentage { get; set; }
        public bool chronicles { get; set; }
        public bool state { get; set; }

        [PrimaryKey]
        public string id { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
