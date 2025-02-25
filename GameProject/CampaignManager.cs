using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public bool AddCampaign(Order order)
        {
            if (order.CampaignId == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
