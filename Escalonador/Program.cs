using System;
using System.Threading;

namespace Escalonador
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficController trafficController = new TrafficController();
            trafficController.DoItall();
        }
    }
}
