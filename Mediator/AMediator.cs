using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AMediator
    {
        protected ConcreateColleague1 colleague1;
        protected ConcreateColleague2 colleague2;
        public AMediator(ConcreateColleague1 colleague1, ConcreateColleague2 colleague2)
        {
            this.colleague1 = colleague1;
            this.colleague2 = colleague2;
        }
        public abstract string NotifyChange(string message, AColleague colleague);
    }
}
