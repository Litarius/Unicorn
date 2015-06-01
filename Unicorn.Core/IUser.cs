using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.Core
{
    public interface IUser
    {
        string Name { get; set; }

        IPAddress IpAddress { get; set; }
    }
}
