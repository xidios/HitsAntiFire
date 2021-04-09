using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurRate
{
    public class FireDipartment
    {
        public int countCalls { get; set; }
        public int firefightersOnCall { get; set; }
        public int firefighters { get; set; }
        public int technicianOnCall { get; set; }
        public int technician { get; set; }
        public double awareness { get; set; }
        public double fireFrequency { get; set; }
        public double fireExtinguishing { get; set; }

        public void UpdateFireFrequency(int externalFactor)
        {
            fireFrequency = externalFactor * ((100 - awareness) * 0.01);
        }
        public void UpdateAwareness()
        {
            awareness = countCalls / 10;
        }
        public void UpdateCalls(Random random)
        {
            if (random.Next(100 - 1) + 1 <= fireFrequency)
            {
                countCalls = ((int)fireFrequency + 1) * 10;
            }
            else
            {
                countCalls = (int)fireFrequency * 10;
            }
        }
        public void UpdateFirefightersOnCall(int total, Random random)
        {
            if (total / 10 < firefighters)
            {
                firefightersOnCall = random.Next(minValue: total / 10, maxValue: firefighters);
            }
            else
            {
                firefightersOnCall = firefighters;
            }
        }
        public void UpdateTechnicianOnCall(int total, Random random)
        {
            if (total / 100 < technician)
            {
                technicianOnCall = random.Next(minValue: total / 100, maxValue: technician);
            }
            else
            {
                technicianOnCall = technician;
            }
        }
        public void UpdateFireExtinguishing()
        {
            fireExtinguishing = (1.05 * firefightersOnCall + 1.2 * technicianOnCall) / (firefightersOnCall + technicianOnCall + 1);

        }
    }
}
