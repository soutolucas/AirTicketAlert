using AirTicketAlert.Core.Entities.Interfaces;
using AirTicketAlert.Core.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketAlert.Core.ValueObjects
{
    class AlertCondition : IAlertCondition
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public bool Check(IAlert alert)
        {
            throw new NotImplementedException();
        }
    }
}
