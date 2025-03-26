using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject.TransferObject
{
    public class SessionManager
    {
        public static int CurrentUserId { get; set; } = 0;
        public static string CurrentUserRole { get; set; } = string.Empty;

    }
}
