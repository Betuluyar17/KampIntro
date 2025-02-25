using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1993 && gamer.FirstName == "Betül" && 
                gamer.LastName == "Uyar" && gamer.IdentityNumber == 22222222222)
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
