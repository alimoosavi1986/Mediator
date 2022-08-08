using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreateMediator : AMediator
    {
        public ConcreateMediator(ConcreateColleague1 colleague1, ConcreateColleague2 colleague2)
            :base(colleague1, colleague2)
        {

        }
        public override string NotifyChange(string message, AColleague colleague)
        {
            if (colleague == colleague1)
            {
                return colleague2.Receive(message);
            }
            else
            {
                return colleague1.Receive(message);
            }
        }
    }
}
