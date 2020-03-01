using ATC.Models.Traffic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATC.Models.Simulation
{
    public class TrafficSim : ITrafficSim
    {
        public TrafficGenerator trafficGen;
        public List<ITraffic> trafficList;

        public TrafficSim()
        {
            trafficGen = new TrafficGenerator();
            trafficList = new List<ITraffic>();
        }

        public void Run()
        {
            Task.Run(GenerateTraffic);
        }

        async Task GenerateTraffic()
        {
            while (true)
            {
                trafficList.Add(trafficGen.GenerateRandomTraffic());
                await Task.Delay(TimeSpan.FromSeconds(10));
            }
        }
    }
}