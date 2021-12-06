using EXPLORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXPLORE.Interfaces
{
   public interface ITokenServices
    {
        string CreateToken(AppUser user);
    }
}
