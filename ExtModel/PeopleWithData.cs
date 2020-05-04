using PED_GEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.ExtModel
{
    class PeopleWithData
    {
        People people;
        List<DiseasesWithPercentage> diseases;

        internal People People { get => people; set => people = value; }
        internal List<DiseasesWithPercentage> Diseases { get => diseases; set => diseases = value; }
    }
}
