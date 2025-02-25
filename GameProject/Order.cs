using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Order
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string OrderName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
