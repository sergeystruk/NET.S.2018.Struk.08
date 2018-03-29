using System;

namespace BankSystem
{
    public abstract class BankAccount
    {
        #region Fields

        private int id;
        private decimal amount;
        private PersonInfo personInfo;
        private int bonusPoints;
        private readonly decimal reserveCache;
        private decimal currentReserveCache;
        private int balanceCost;
        private int transactionCost;

        #endregion

        #region Consructures

        public BankAccount(PersonInfo ownersInfo, int cache, int personalBalanceCost, int personalTransactionCost)
        {
            personInfo = ownersInfo;
            reserveCache = cache;
            currentReserveCache = reserveCache;
            balanceCost = personalBalanceCost;
            transactionCost = personalBalanceCost;
        }

        #endregion

        #region API

        public void Withdraw(decimal sumOfWithdraw)
        {
            if (sumOfWithdraw <= 0)
            {
                throw new ArgumentNullException($"Parameter {nameof(sumOfWithdraw)} can not be less then 0 or equal 0");
            }
            
            if (sumOfWithdraw > amount)
            {
                if (sumOfWithdraw > amount + currentReserveCache)
                {
                    
                }
                else
                {
                    sumOfWithdraw -= amount;
                    amount = 0;
                    currentReserveCache -= sumOfWithdraw;   
                }
            }
            else
            {
                amount -= sumOfWithdraw;
            }
        }

        public void Deposit(decimal sumOfDeposit)
        {
            if (sumOfDeposit <= 0)
            {
                throw new ArgumentNullException($"Parameter {nameof(sumOfDeposit)} can not be less then 0 or equal 0");
            }

            if (currentReserveCache < reserveCache)
            {
                if (sumOfDeposit <= reserveCache - currentReserveCache)
                {
                    currentReserveCache += sumOfDeposit;
                }
                else
                {
                    amount += sumOfDeposit - (reserveCache - currentReserveCache);
                    currentReserveCache = reserveCache;
                }
            }
            amount += sumOfDeposit;
        }

        #endregion
    }
}
