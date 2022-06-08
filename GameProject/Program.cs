using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 0;
            player.FirstName = "Okan";
            player.LastName = "Yılmaz";
            player.NationalityId = "123456";

            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());

            playerManager.Save(player);
            playerManager.Update(player);
            playerManager.Delete(player);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "2 Alana 1 Bedava";
            campaign.CampaignDetails = "Belirlenen oyunlar içerisinden 2 adet oyun alana 3. oyun bedava!";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            OrderManager orderManager = new OrderManager();
            orderManager.SaleWithCampaign(campaign, new Game { GameName = "Fifa 2022", GameType = "Futbol", Id = 1, UnitPrice = 15 }, player);
            orderManager.Sale(player, new Game { GameName = "Fifa 2022", GameType = "Futbol", Id = 2, UnitPrice = 15 });
        }
    }
}
