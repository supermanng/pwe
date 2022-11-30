using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Enums
{
    public enum NotificationTypeEnum
    {
        EmailWithSMTP = 1,
        EmailWithCredentials,
        SMS,
        PushNotification
    }

    public enum GrantTypeEnum
    {
        client_credentials, password

    }
    public enum ProductTypeEnum
    {
        Savings, Investments, Wallet
    }
    //ActionTypeEnum
    public enum ActionTypeEnum
    {

        CreateInvestment,
        FundWallet
    }
    public enum InterestCalculationTime
    {
        AfterMaturity, Monthly, Daily, NotApplicable, Upfront
    }
    public enum FrequencyEnum
    {
        Daily, Weekly, Monthly, Yearly, None
    }
    public enum TransactionTypeEnum
    {
        WalletTopUp,
        InvestmentTopUp,
        SavingsTopUp
    }
    public enum AccountEnum
    {
        CustomerWalletAccount,
        BaigeWalletChargeAccount,
        BaigeWalletBankAccount
    }
    public enum TransactionStatusEnum
    {
        Pending, Failed, Succeded
    }

}
