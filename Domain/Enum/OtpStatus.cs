using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public enum OtpStatus
    {
        Initiated, Verified, Failed, Blocked
    }
    public enum TransactionStatus
    {
        Pending, Failed, Succeded
    }
    public enum TransactionType
    {
        WalletTopUp,
        InvestmentTopUp,
        SavingsTopUp
    }
}
