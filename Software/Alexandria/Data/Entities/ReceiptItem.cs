namespace Data.Entities
{
    public class ReceiptItem
    {
        public int Receipt_Id { get; set; }

        public int Loan_Id { get; set; }

        public Loan Loan { get; set; }

        public Receipt Receipt { get; set; }

        public double Money { get; set; }

        public ReceiptItem()
        {

        }

        public ReceiptItem(Loan loan, Receipt receipt, double money)
        {
            Loan = loan;
            Receipt = receipt;
            Money = money;
        }
    }
}
