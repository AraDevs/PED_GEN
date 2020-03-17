using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Models
{
    class People: RealmObject
    {
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public bool deceased { get; set; }
        public IList<People> sons { get; }
        public IList<Diseases> diseases { get; }
        public IList<Allergies> allergies { get; }
        public People spouse { get; set; }


        [PrimaryKey]
        public string id { get; set; }

    }
}
