namespace OOP
{
    public static class Kata
    {
        public static int СenturyFromYear(int year)
        {
            if (year % 100 > 0)
            {
                return (year / 100) + 1;
            }
            else
            {
                return year / 100;
            }

            //return (year + 99) / 100;

            //return year % 100 > 0 ? (year / 100) + 1 : year / 100;
        }
    }
}
