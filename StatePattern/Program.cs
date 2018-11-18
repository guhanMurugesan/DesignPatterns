using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 press;
            IState state = new OfflineState();
            bool isOnline = false;
            do
            {
                Console.WriteLine("1.start \n2.stop\n3.drive\n\nEnter state:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "start":
                        if (!isOnline)
                        {
                            state = new OnlineState();
                            isOnline = true;
                        }
                        
                        break;
                    case "stop":
                        if(isOnline)
                        {
                            state = new OfflineState();
                            isOnline = false;
                        }
                        break;
                    case "drive":
                        state.Drive();
                        break;
                }
                Console.WriteLine("press 1 to continue");
                press = Convert.ToInt16(Console.ReadLine());
            }while(press == 1);
        }
    }
}
