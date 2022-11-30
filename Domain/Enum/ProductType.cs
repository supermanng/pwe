using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public enum ProductType
    {
        Savings, Investments, Wallet, Prestige
    }
    public enum InterestIsPaid
    {
        AfterMaturity, Monthly
    }
    public enum InterestCalculationTime
    {
        AfterMaturity, Monthly, Daily, NotApplicable, Upfront
    }
    public enum Frequency
    {
        Daily, Weekly, Monthly, Yearly, None
    }
    public enum ActionType
    {
        WalletTopUp,
        InvestmentTopUp,
        SavingsTopUp
    }
    public enum Personality
    {
        CustomerAccount,
        OrganizationAccount
    }
    public enum AccountStructure
    {
        CustomerWalletAccount,
        BaigeWalletChargeAccount,
        BaigeWalletBankAccount
    }
}
