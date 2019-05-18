using System;
using System.Collections.Generic;
using System.Text;

namespace tohka.Enums
{
    public enum LoginResponses
    {
        FAILED = -1,
        OUTDATED = -2,
        BANNED = -3,
        MULTIACC = -4,
        EXCEPTION = -5,
        SUPPORTERONLY = -6,
        TWOFACTORAUTH = -8,
    }
}
