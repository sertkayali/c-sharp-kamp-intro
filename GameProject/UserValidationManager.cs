using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "FURKAN" && gamer.LastName == "SERTKAYALI" && 
                gamer.IdentityNumber == 36636363636)
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
