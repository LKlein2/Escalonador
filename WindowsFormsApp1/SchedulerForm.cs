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
            ShowAirplanes();
        }

        public void ShowAirplanes()
        {
            TrafficController trafficController = new TrafficController();
            trafficController.DoItall();

            List<Airplane> Pista20Up   = trafficController.T1.AirplanesToUp;
            List<Airplane> Pista20Down = trafficController.T1.AirplanesToDown;

            List<Airplane> Pista15Up   = trafficController.T2.AirplanesToUp;
            List<Airplane> Pista15Down = trafficController.T2.AirplanesToDown;

            List<Airplane> Pista10Up   = trafficController.T3.AirplanesToUp;
            List<Airplane> Pista10Down = trafficController.T3.AirplanesToDown;

            List<Airplane> PistaPouso     = trafficController.PP.AirplanesToDown;
            List<Airplane> PistaDecolagem = trafficController.PD.AirplanesToUp;

            new Thread(() => 
            {




            }).Start();
        }
    }
}
