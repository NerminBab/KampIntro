using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.FirstName=="Nermin" && player.LastName=="Babalık")
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
