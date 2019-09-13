using ChatBotDBAccess;
using GetMonitorOnSizeContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnSizeLib
{
    public class GetMonitorOnSize : IGetMonitorOnSize
    {
        List<string> IGetMonitorOnSize.GetMonitorOnSize(string size)
        {
             using (ChatBotDBEntities1 entities = new ChatBotDBEntities1())
            {
                return (entities.Monitors.Where(e => e.Spec2.ToLower() == size.ToLower()).Select(Column => Column.ModelNo).ToList());
            }
        }
    }
}
