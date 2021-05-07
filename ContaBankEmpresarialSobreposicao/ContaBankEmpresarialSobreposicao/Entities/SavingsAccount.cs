namespace ContaBankEmpresarialSobreposicao.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Após utilização do virtual basta colocar a lógica a ser seguida.
        public override void Withdraw(double amount)
        {
            //a palavra "base" chama a implementação da superclasse.
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}