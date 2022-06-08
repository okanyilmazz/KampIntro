using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Save(Player player)
        {
            Console.WriteLine(player.FirstName + " kişisi eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " kişisi silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " kişisi güncellendi");
        }
    }
}
