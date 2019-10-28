using Escalonador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class SCH001 : Form
    {
        public SCH001()
        {
            InitializeComponent();
            Thread t = new Thread(ShowAirplanes);
            t.Start();
        }

        public void ShowAirplanes()
        {
            TrafficController trafficController = new TrafficController();
            trafficController.DoItall();
            while (true)
            {
                List<Airplane> Pista20Up   = trafficController.T1.AirplanesToUp;
                List<Airplane> Pista20Down = trafficController.T1.AirplanesToDown;

                List<Airplane> Pista15Up   = trafficController.T2.AirplanesToUp;
                List<Airplane> Pista15Down = trafficController.T2.AirplanesToDown;

                List<Airplane> Pista10Up   = trafficController.T3.AirplanesToUp;
                List<Airplane> Pista10Down = trafficController.T3.AirplanesToDown;

                List<Airplane> PistaPouso     = trafficController.PP.AirplanesToUp;
                List<Airplane> PistaDecolagem = trafficController.PD.AirplanesToUp;

                string airplanes20 = "", airplanes15 = "", airplanes10 = "", airplanesP = "", airplanesD = "";
                
                #region Pista 20
                foreach (var item in Pista20Up)
                {
                    airplanes20 += "✈ " + item.Index.ToString() + " ";
                }
                foreach (var item in Pista20Down)
                {
                    airplanes20 += "✈ " + item.Index.ToString() + " ";
                }
                #endregion

                #region pista 10
                foreach (var item in Pista10Up)
                {
                    airplanes10 += "✈ " + item.Index.ToString() + " ";
                }
                foreach (var item in Pista10Down)
                {
                    airplanes10 += "✈ " + item.Index.ToString() + " ";
                }
                #endregion

                #region Pista 15
                foreach (var item in Pista15Up)
                {
                    airplanes15 += "✈ " + item.Index.ToString() + " ";
                }
                foreach (var item in Pista15Down)
                {
                    airplanes15 += "✈ " + item.Index.ToString() + " ";
                }
                #endregion

                #region Pouso
                foreach (var item in PistaPouso)
                {
                    airplanesP += "✈ " + item.Index.ToString() + " ";
                }
                #endregion

                #region Decolagem
                foreach (var item in PistaDecolagem)
                {
                    airplanesD += "✈ " + item.Index.ToString() + " ";
                }
                #endregion

                UpdateText(label1, airplanes20);
                UpdateText(label2, airplanes15);
                UpdateText(label3, airplanes10);
                UpdateText(label4, airplanesP);
                UpdateText(label5, airplanesD);
                Thread.Sleep(1000);
            }

        }

        public void UpdateText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke((MethodInvoker) delegate () { label.Text = text; });
            }
            else
            {
                label.Text = text;
            }
        }

        private void SCH001_Load(object sender, EventArgs e)
        {

        }
    }
}
