using GetModelContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;

namespace GetModelLib
{
    public class GetModel : IGetModel
    {
        List<Monitor> IGetModel.GetModel(string model)
        {
            using (ChatBotDBEntities1 entities = new ChatBotDBEntities1())
            { return entities.Monitors.Where(e => e.ModelNo.ToLower() == model.ToLower()).ToList(); }
        }
    }
}
