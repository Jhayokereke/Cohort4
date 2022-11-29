namespace OOP
{
    public class TheBulb
    {
        public decimal Principal { get; set; }
        public delegate decimal InterestDelegate(decimal pricipal, double rate, int time);
        public delegate void InfoDelegate(string name, int time, decimal interest);
        public void OnBoarding(string student, InterestDelegate interestCalculator, InfoDelegate information)
        {
            double rate = 0.15;
            int time = 3;

            decimal interestAccrued = interestCalculator(Principal, rate, time);

            information(student, time, interestAccrued);
        }
    }
}
