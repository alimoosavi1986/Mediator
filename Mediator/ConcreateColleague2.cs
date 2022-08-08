using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreateColleague2 : AColleague
    {
        public override string Send(string message)
        {
            return base.Send(message);
        }

        public string Receive(string message)
        {
            return $"ConcreateColleague2 Receiveed: {message}";
        }
    }
}
