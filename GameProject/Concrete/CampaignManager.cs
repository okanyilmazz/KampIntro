﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası silindi");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası eklendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası güncellendi");
        }
    }
}
