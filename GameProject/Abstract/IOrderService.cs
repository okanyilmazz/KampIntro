using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Sale(Player player, Game game);
        void SaleWithCampaign(Campaign campaign,Game game, Player player);
    }
}
