using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Escalonador
{
    public class TrafficController
    {
        private Transition T1, T2, T3, PP, PD;
        private Airplane[] Airplanes = new Airplane[20];

        public TrafficController()
        {
            T1 = new Transition("ESTRADA 20000 METROS DE ALTURA", 4, 7);
            T2 = new Transition("ESTRADA 15000 METROS DE ALTURA", 3, 6);
            T3 = new Transition("ESTRADA 10000 METROS DE ALTURA", 2, 7);
            PP = new Transition("PISTA DE POUSO", 2, 1);
            PD = new Transition("PISTA DE DECOLAGEM", 2, 1);
            InstanceAirplanes();
            ConfigureDestinations();
        }

        public void ConfigureDestinations()
        {
            T1.ConfigureDestination(T2, null);
            T2.ConfigureDestination(T3, T1);
            T3.ConfigureDestination(PP, T2);
            PP.ConfigureDestination(PD, T3);
            PD.ConfigureDestination(null, T3);
        }

        public void InstanceAirplanes()
        {
            for (int i = 0; i < 20; i++)
            {
                Airplanes[i] = new Airplane(i);
            }
        }

        public void DoItall()
        {
            Thread MainThread = new Thread(InitializeList);
            MainThread.Start();
        }

        public void InitializeList()
        {
            int currentIndex = 0;
            while (currentIndex < Airplanes.Length)
            {
                if (T1.HasSpace())
                {
                    T1.AddAirplane(Airplanes[currentIndex], Flow.Down);
                    currentIndex++;
                }
            }
        }


    }
}
