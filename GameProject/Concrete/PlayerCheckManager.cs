using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfPlayer(Player player)
        {
            return true;
        }
    }
}
