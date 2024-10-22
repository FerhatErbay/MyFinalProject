﻿using System;
using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JsonWebToken
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
