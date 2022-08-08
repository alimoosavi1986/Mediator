using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateColleague1 c1 = new ConcreateColleague1();
            ConcreateColleague2 c2 = new ConcreateColleague2();
            ConcreateMediator mediator = new ConcreateMediator(c1,c2);

            c1.SetMediator(mediator);
            c2.SetMediator(mediator);

            Console.WriteLine(c1.Send("Hello"));
            Console.WriteLine(c2.Send("I'm Fine"));

            Console.ReadKey();
        }
    }
}
