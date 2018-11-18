using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IState
    {
        void Drive();
    }

    public class OnlineState : IState
    {

        public void Drive()
        {
            Console.WriteLine("Driving..........");
        }
    }

    public class OfflineState : IState
    {

        public void Drive()
        {
            Console.WriteLine("please start the vehicle");
        }
    }
}
