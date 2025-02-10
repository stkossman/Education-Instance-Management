using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduInst.PL.LoginForm
{
    public static class SessionManager
    {
        public static int LoggedInUserId { get; set; }
        public static string Role { get; set; }
    }
}
