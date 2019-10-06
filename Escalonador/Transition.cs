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
        public Transition DestinationUp { get; set; }
        public Transition DestinationDown { get; set; }

        private List<Airplane> Airplanes;
        private int Limit;

        public Transition(string name, int time, int limit)
        {
            Name = name;
            Time = time;
            Limit = limit;
            Airplanes = new List<Airplane>();
        }

        public void ConfigureDestination (Transition destinationUp, Transition destinationDown)
        {
            this.DestinationUp = destinationUp;
            this.DestinationDown = destinationDown;
        }

        public bool HasSpace()
        {
            return Airplanes.Count < Limit;
        }

        public void AddAirplane(Airplane airplane, Flow flow)
        {
            Airplanes.Add(airplane);
            Console.WriteLine($"Airplane {airplane.Index} just entered {this.Name}.");
            Thread.Sleep(this.Time * 1000);

            Thread T1 = new Thread(() => DelegateAriplane(airplane, flow));
            T1.Start();
        }

        private void DelegateAriplane(Airplane airplane, Flow flow)
        {
            while (true)
            {
                if (flow == Flow.Up)
                {
                    if (DestinationUp != null)
                    {
                        if (DestinationUp.HasSpace())
                        {
                            DestinationUp.AddAirplane(airplane, Flow.Up);
                            break;
                        }
                    }
                    else
                    {
                        if (DestinationDown.HasSpace())
                        {
                            DestinationDown.AddAirplane(airplane, Flow.Down);
                            break;
                        }
                    }
                }
                else if (flow == Flow.Down)
                {
                    if (DestinationDown != null)
                    {
                        if (DestinationDown.HasSpace())
                        {
                            DestinationDown.AddAirplane(airplane, Flow.Down);
                            break;
                        }
                    }
                    else
                    {
                        if (DestinationUp.HasSpace())
                        {
                            DestinationUp.AddAirplane(airplane, Flow.Up);
                            break;
                        }
                    }
                }
                Thread.Sleep(1000);
            }
            Airplanes.RemoveAt(0);
        }
    }
}
