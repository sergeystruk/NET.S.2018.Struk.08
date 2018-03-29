namespace BankSystem
{
    public class PlatinumAccount : BankAccount
    {
        private const int reservedCacheBase = 10000;
        private const int balanceCost = 5;
        private const int transactionCost = 5;

        public PlatinumAccount(PersonInfo personInfo) : base(personInfo, reservedCacheBase, balanceCost, transactionCost) { }
    }
}