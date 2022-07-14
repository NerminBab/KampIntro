using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
