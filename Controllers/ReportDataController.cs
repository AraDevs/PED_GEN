using PED_GEN.ExtModel;
using PED_GEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Controllers
{
    
    class ReportDataController
    {
        PeopleController pc = new PeopleController();

        public ReportDataController()
        {

        }

        public List<PeopleWithData> getReportData()
        {
            List<PeopleWithData> tempPeople = new List<PeopleWithData>();
            List<People> allPeople = pc.getItems();
            List<Diseases> allDiseases = new DiseasesController().getActiveItems();
            
            
            foreach (People p in allPeople)
            {
                PeopleWithData pwd = new PeopleWithData();
                pwd.People = p;
                pwd.Diseases = new List<DiseasesWithPercentage>();
                foreach(Diseases d in allDiseases)
                {
                    if (!p.diseases.Contains(d))
                    {
                        int total = countPeopleWithDisease(allPeople, d);
                        bool flag = false;
                        foreach (DiseasesWithPercentage dwp in pwd.Diseases)
                        {
                            if (dwp.Name.Equals(d.name))
                            {
                                flag = true;
                                dwp.Percentage += (d.percentage * aleatoryVariation(0.005,0.01)) * total * 100;
                            }
                        }
                        if (!flag)
                        {
                            pwd.Diseases.Add(new DiseasesWithPercentage((d.percentage * aleatoryVariation(0.002, 0.003)) * total * 100, d.name));
                        }
                    }
                    
                }
                tempPeople.Add(pwd);
            }

            return tempPeople;
        }

        private int countPeopleWithDisease(List<People> p, Diseases d)
        {
            int count = 0;
            foreach (People people in p)
            {
                foreach(Diseases diseases in people.diseases)
                {

                    if (diseases.name.Equals(d.name)){
                        count++;
                    }
                }
            }
            return count;
        }


        public double aleatoryVariation(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
