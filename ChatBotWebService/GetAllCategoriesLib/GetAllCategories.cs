using ChatBotDBAccess;
using GetAllCategoriesContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllCategoriesLib
{
    public class GetAllCategories : IGetAllCategories
    {
        List<string> IGetAllCategories.GetAllCategories()
        {
            using (ChatBotDBEntities1 entities = new ChatBotDBEntities1())
            {
                return (entities.Monitors.Select(Column => Column.Category).Distinct().ToList());
            }
        }
    }
}
