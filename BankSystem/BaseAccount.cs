namespace BankSystem
{
    public class BaseAccount : BankAccount
    {
        private const int reservedCacheBase = 0;
        private const int balanceCost = 1;
        private const int transactionCost = 1;

        public BaseAccount(PersonInfo personInfo) : base(personInfo, reservedCacheBase, balanceCost, transactionCost) { }
    }
}