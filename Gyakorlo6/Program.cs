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
    }
}