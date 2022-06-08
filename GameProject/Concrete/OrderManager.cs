using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {


        public void Sale(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " Oyuncusu " + game.GameName + " oyununu satın aldı");
        }

        public void SaleWithCampaign(Campaign campaign, Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " Oyuncusu " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyasını kullanarak satın aldı");
        }
    }
}