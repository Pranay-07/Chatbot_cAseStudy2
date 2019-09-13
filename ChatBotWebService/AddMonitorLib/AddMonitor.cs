using AddMonitorContractsLib;
using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMonitorLib
{
    public class AddMonitor : IAddMonitor
    {
        Monitor IAddMonitor.AddMonitor(Monitor model)
    
        {

            using (ChatBotDBEntities1 entities = new ChatBotDBEntities1())
            {
                var entity = entities.Monitors.Add(model);
                entities.SaveChanges();
                return entity;

            }
        }
    }
}
