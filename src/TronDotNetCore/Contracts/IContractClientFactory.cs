﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDotNetCore.Contracts
{
    public interface IContractClientFactory
    {
        IContractClient CreateClient(ContractProtocol protocol);
    }
}
