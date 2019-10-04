using AirTicketAlert.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketAlert.Core.ValueObjects.Interfaces
{
    public interface IAlertCondition
    {
        bool Check(IAlert alert);

        void Add();
    }
}
