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

        public List<Airplane> AirplanesToUp;
        public List<Airplane> AirplanesToDown;

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
                //Console.WriteLine($"Airplane {airplane.Index} just entered in  {this.Name}");
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
                        Airplane a = AirplanesToUp[0];
                        AirplanesToUp.RemoveAt(0);
                        if (DestinationUp != null)
                        {
                            DelegateUp(a);
                        }
                        else
                        {
                            DelegateDown(a);
                        }
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
                        Airplane a = AirplanesToDown[0];
                        AirplanesToDown.RemoveAt(0);
                        if (DestinationDown != null)
                        {
                            DelegateDown(a);
                        }
                        else
                        {
                            DelegateUp(a);
                        }
                    }
                }
            }).Start();
        }

        public void DelegateUp(Airplane a)
        {
            while (true)
            {
                if (DestinationUp.HasSpace())
                {
                    DestinationUp.AddAirplane(a, Flow.Up);
                    break;
                }
            }
        }

        public void DelegateDown(Airplane a)
        {
            while (true)
            {
                if (DestinationDown.HasSpace())
                {
                    DestinationDown.AddAirplane(a, Flow.Down);
                    break;
                }
            }
        }

    }
}
