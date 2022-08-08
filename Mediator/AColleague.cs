using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AColleague
    {
        protected AMediator mediator;

        public void SetMediator(AMediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual string Send(string message)
        {
            return mediator.NotifyChange(message, this);
        }

    }
}
