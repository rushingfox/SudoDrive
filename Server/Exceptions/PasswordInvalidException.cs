using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Exceptions
{
    public class PasswordInvalidException:APIException
    {
        public PasswordInvalidException(object data = null) : base(-104, "The password was not match the format requirements.", data)
        {
        }
    }
}
