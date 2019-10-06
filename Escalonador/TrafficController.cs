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
            /* Inicialização */
            new Thread(() =>
            {
                int currentIndex = 0;
                while (currentIndex < (Airplanes.Length - 1))
                {
                    if (T1.AddAirplane(Airplanes[currentIndex], Flow.Down) == 0)
                    {
                        currentIndex++;
                        break;
                    }
                }
            }).Start();

            /* Pista 20000 */
            new Thread(() =>
            {

            }).Start();

            /* Pista 15000 */
            new Thread(() =>
            {

            }).Start();

            /* Pista 10000 */
            new Thread(() =>
            {

            }).Start();

            /* Pista POUSO */
            new Thread(() =>
            {

            }).Start();

            /* Pista DESCOLAGEM */
            new Thread(() =>
            {

            }).Start();
        }
    }
}
