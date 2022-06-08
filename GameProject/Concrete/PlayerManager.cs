using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfPlayer(player))
            {
                Console.WriteLine(player.FirstName + " kişisi eklendi");
            }
            else
            {
                throw new Exception("Oyuncu bulunamadı");
            }

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
