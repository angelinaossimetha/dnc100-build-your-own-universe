using System;

namespace dnc100_build_your_own_universe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Universe universe = new Universe();
            Random rnd = new Random();


            foreach (int g in Enumerable.Range(1, 1000)) {
                Galaxy gTemp = new Galaxy();
                universe.AddGalaxy(gTemp);

                foreach (int ss in Enumerable.Range(1, 200)) { 
                    SolarSystem ssTemp = new SolarSystem();
                    gTemp.AddSolarSystem(ssTemp);
                    ssTemp.AddStar(new Star());
                    
                    foreach (int p in rnd.Next(10, 16)) {
                        Planet pTemp = new Planet();
                        ssTemp.AddPlanet(pTemp);
                        foreach (int lf in rnd.Next(10000, 10000000001)) { 
                            LifeForm lfTemp = new LifeForm();
                            pTemp.AddLifeForm(lfTemp);
                        }
                    }
                }
                //Console.WriteLine("Done!!!!!!!!!!!!");
            }
        }
    }
}
