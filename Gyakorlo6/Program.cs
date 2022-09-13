namespace Gyakorlo6
{
    class Gyakorlo6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Abcdef1 megfelelő jelszó? " + PasswordCheck("Abcdef1"));
            Console.WriteLine("Abcdef12 megfelelő jelszó? " + PasswordCheck("Abcdef12"));
            Console.WriteLine("Abcdef1g megfelelő jelszó? " + PasswordCheck("Abcdef1g"));
            Console.WriteLine("Abcdefgh123 megfelelő jelszó? " + PasswordCheck("Abcdefgh123"));

            Console.WriteLine("Nagybetűk száma: " + UpperCaseLetterInString("AbcDEFef1g"));
            Console.WriteLine("Számjegyek száma: " + DigitInString("Abcdefgh123"));

            string szoveg1, szoveg2;
            szoveg1 = Console.ReadLine();
            szoveg2 = Console.ReadLine();
            Console.WriteLine($"{szoveg1} és {szoveg2} közös metszete: {prefix(szoveg1,szoveg2)}");
        }

        public static Boolean PasswordCheck(string password)
        {
            if(password.Length < 8)
                return false;
            int szamok = 0;
            foreach(char c in password)
            {
                if (!Char.IsDigit(c) && !Char.IsLetter(c))
                    return false;
                if (Char.IsDigit(c))
                    szamok++;
            }
            if (szamok < 2)
                return false;
            return true;
        }

        public static int UpperCaseLetterInString(string szoveg)
        {
            int szam = 0;
            foreach(char c in szoveg)
            {
                if (Char.IsUpper(c))
                    szam++;
            }
            return szam;
        }

        public static int DigitInString(string szoveg)
        {
            int szam = 0;
            foreach (char c in szoveg)
            {
                if (Char.IsDigit(c))
                    szam++;
            }
            return szam;
        }

        public static String prefix(String s1, String s2)
        {
            int rovidebbSzovegHossza = s1.Length < s2.Length ? s1.Length : s2.Length;
            int egyezik = 0;
            for(int i = 0; i < rovidebbSzovegHossza; i++)
            {
                if (s1[i].Equals(s2[i]))
                    egyezik++;
            }
            if(egyezik > 0)
            {
                return s1.Substring(0, egyezik);
            }
            return String.Empty;
        }
    }
}