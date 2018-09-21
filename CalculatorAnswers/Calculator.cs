namespace CalculatorAnswers
{
    public class Calculator
    {
        public int CurrentTotal { get; set; }

        public Calculator()
        {
            this.CurrentTotal = 0;
        }

        public Calculator(int InitialValue)
        {
            this.CurrentTotal = InitialValue;
        }

        public void SetCurrentTotal(int NewCurrentTotal)
        {
            this.CurrentTotal = NewCurrentTotal;
        }

        public int GetCurrentTotal()
        {
            return this.CurrentTotal;
        }

        public void Add(int NumberToAddToCurrentTotal)
        {
            this.CurrentTotal += NumberToAddToCurrentTotal;
        }

        public void Subtract(int NumberToSubtractFromCurrentTotal)
        {
            this.CurrentTotal -= NumberToSubtractFromCurrentTotal;
        }

        public void Multiply(int NumberToMultiplyCurrentTotalWith)
        {
            this.CurrentTotal *= NumberToMultiplyCurrentTotalWith;
        }
    }
}