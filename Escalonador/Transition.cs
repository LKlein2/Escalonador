using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Escalonador
{
    public class Transition
    {
        public string Name { get; set; }
        public int  Time { get; set; }
        private int Limit;

        public Transition DestinationUp { get; set; }
        public Transition DestinationDown { get; set; }

        private List<Airplane> AirplanesToUp;
        private List<Airplane> AirplanesToDown;

        public Transition(string name, int time, int limit)
        {
            Name = name;
            Time = time;
            Limit = limit;
            AirplanesToUp = new List<Airplane>();
            AirplanesToDown = new List<Airplane>();
        }

        public void ConfigureDestination (Transition destinationUp, Transition destinationDown)
        {
            this.DestinationUp = destinationUp;
            this.DestinationDown = destinationDown;
        }

        private bool HasSpace()
        {
            return (AirplanesToUp.Count + AirplanesToDown.Count) < Limit;
        }

        public int AddAirplane(Airplane airplane, Flow flow)
        {
            if (HasSpace())
            {
                Console.WriteLine($"Airplane {airplane.Index} just entered in  {this.Name}");
                if (flow == Flow.Up) AirplanesToUp.Add(airplane);
                else AirplanesToDown.Add(airplane);
                return 0;
            }
            return 1;
        }

        public void Delegations()
        {
            new Thread(() =>
            {
                while (true)
                {
                    if (AirplanesToUp.Count > 0)
                    {
                        Thread.Sleep(Time * 1000);

                    }
                }
            }).Start();

            new Thread(() =>
            {
                while (true)
                {
                    if (AirplanesToDown.Count > 0)
                    {
                        Thread.Sleep(Time * 1000);

                    }
                }
            }).Start();
        }

        //public void DelegateAriplane()
        //{
        //    while (true)
        //    {
        //        if (flow == Flow.Up)
        //        {
        //            if (DestinationUp != null)
        //            {
        //                if (DestinationUp.HasSpace())
        //                {
        //                    DestinationUp.AddAirplane(airplane, Flow.Up);
        //                    break;
        //                }
        //            }
        //            else
        //            {
        //                if (DestinationDown.HasSpace())
        //                {
        //                    DestinationDown.AddAirplane(airplane, Flow.Down);
        //                    break;
        //                }
        //            }
        //        }
        //        else if (flow == Flow.Down)
        //        {
        //            if (DestinationDown != null)
        //            {
        //                if (DestinationDown.HasSpace())
        //                {
        //                    DestinationDown.AddAirplane(airplane, Flow.Down);
        //                    break;
        //                }
        //            }
        //            else
        //            {
        //                if (DestinationUp.HasSpace())
        //                {
        //                    DestinationUp.AddAirplane(airplane, Flow.Up);
        //                    break;
        //                }
        //            }
        //        }
        //        Thread.Sleep(1000);
        //    }
        //    Airplanes.RemoveAt(0);
        //}

    }
}
