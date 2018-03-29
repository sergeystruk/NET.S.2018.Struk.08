namespace BankSystem
{
    public class GoldAccount : BankAccount
    {
        private const int reservedCacheBase = 5000;
        private const int balanceCost = 3;
        private const int transactionCost = 3;

        public GoldAccount(PersonInfo personInfo) : base(personInfo, reservedCacheBase, balanceCost, transactionCost) { }
    }
}