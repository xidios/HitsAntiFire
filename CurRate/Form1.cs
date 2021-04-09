using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        const int oneHundred = 100;




        public int countCurFire;
        public double totalArea;
        

        Random random = new Random();
        public List<Fire> fires = new List<Fire>();
        public FireDipartment fireDipartment = new FireDipartment();
        public int externalFactor;


        int daysSpent = 0;

        private void refreshUI()
        {
            labelFireExtinguishingRate.Text = fireDipartment.fireExtinguishing.ToString();
            labelAwareness.Text = fireDipartment.awareness.ToString();
            labelFireFreq.Text = fireDipartment.fireFrequency.ToString();
        }

        private void startGame()
        {
            totalArea = 0;
            fires.Clear();
            fireDipartment.firefighters = (int)fightersNumber.Value;
            fireDipartment.technician = random.Next(99) + 1;


            for (int i = 0; i < (int)currentFiresAmount.Value; i++)
            {
                Fire fire = new Fire(random);
                fires.Add(fire);
            }
            externalFactor = random.Next(99) + 1;
            fireDipartment.awareness = random.Next(99) + 1;


            fireDipartment.UpdateFireFrequency(externalFactor);


            fireDipartment.UpdateCalls(random);



            for (int i = 0; i < fires.Count; i++)
                totalArea += fires[i].TotalArea;
            daysSpent = 0;

            refreshUI();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = daysSpent + 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, (int)totalArea * 2);
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            totalArea = 0;
            for (int i = 0; i < fires.Count; i++)
                totalArea += fires[i].TotalArea;
            externalFactor = random.Next(99) + 1;

            fireDipartment.UpdateAwareness();
            fireDipartment.UpdateFireFrequency(externalFactor);

            if (fireDipartment.fireFrequency * random.Next(100) > fireDipartment.fireFrequency * 1)
            {
                Fire fire = new Fire(random);
                fires.Add(fire);
            }

            fireDipartment.UpdateCalls(random);

            fireDipartment.UpdateFirefightersOnCall((int)totalArea, random);

            fireDipartment.UpdateTechnicianOnCall((int)totalArea, random);

            totalArea = Math.Abs(totalArea * ((1 + fireDipartment.fireFrequency) / 100) - fireDipartment.fireExtinguishing + random.Next((random.Next(2)) * countCurFire) / (oneHundred - 95));
            fireDipartment.UpdateFireExtinguishing(); 
            refreshUI();
            chart1.ChartAreas[0].AxisX.Maximum = daysSpent + 1;

            chart1.Series[0].Points.AddXY(++daysSpent, (int)totalArea);

        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startGame();
        }

        private void stopGameBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
