using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Add(Order order)
        {
            if (_campaignService.AddCampaign(order))
            {
                Console.WriteLine("Ramazan kampanyası uygulandı.");
            }
            else
            {
                Console.WriteLine("Kampanya tarihi geçersiz.");
            }
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
