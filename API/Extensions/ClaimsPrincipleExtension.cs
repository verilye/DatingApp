using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtension
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        //METHOD IS BROKEN FOR SOME REASON, LOOK AT HOW EACH VALUE IS BEING
        //STORE ON THE DB COMPARED TO JWT AND DTOS
        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}