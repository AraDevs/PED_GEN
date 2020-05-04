using PED_GEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.ExtModel
{
    class DiseasesWithPercentage
    {
        string name;
        double percentage;

        public double Percentage { get => percentage; set => percentage = value; }
        public string  Name { get => name; set => name = value; }

        public DiseasesWithPercentage(double percentage, string name)
        {
            Percentage = percentage;
            Name = name;
        }
    }
}
