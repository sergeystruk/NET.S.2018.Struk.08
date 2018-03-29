namespace BankSystem
{
    public class SilverAccount : BankAccount
    {
        private const int reservedCacheBase = 1000;
        private const int balanceCost = 2;
        private const int transactionCost = 2;

        public SilverAccount(PersonInfo personInfo) : base(personInfo, reservedCacheBase, balanceCost, transactionCost) { }
    }
}