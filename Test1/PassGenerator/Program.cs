using System;

namespace PassGenerator
{
    internal class Program
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            
            if(!IsValid(args))
            {
                ShowHelpText();
     
                return;

            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];

            var pattern = options.PadRight(lenght, '1');

            var password = string.Empty;
            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];
                pattern = pattern.Substring(0, randomIndex) 
                          + pattern.Substring(randomIndex + 1, pattern.Length -1);
                if (category == 'l') password += GetRandomLowerCaseLetter();
                else if(category == 'L') password += GetRandomUpperCaseLetter();
                else if(category == 'd') password += GetRandomDigit();
                else password += GetRandomSpecialChar();
            }
            Console.WriteLine(password);
            Console.ReadLine();


            

        }
        private static char GetRandomLowerCaseLetter()
        {
            var min = 'a';
            var max = 'z';

            return (char)Random.Next(min, max);
        }
        private static char GetRandomUpperCaseLetter()
        {
            var min = 'A';
            var max = 'Z';

            return (char) Random.Next(min, max);
        }
        private static char GetRandomDigit()
        {
            return Random.Next(0, 9).ToString()[0];
        }
        private static char GetRandomSpecialChar()
        {
            var allSpecialChar = "(!\"#¤%&(){}[]";
            var index = Random.Next(0, allSpecialChar.Length - 1);
            return allSpecialChar[index];
        }
        private static bool IsValid(string[] args)
        {
            bool isValid = true;
            if (args.Length != 2)return false;

            
            var lengthStr = args[0];
            var options = args[1];

            foreach (var character in options)
            {
                if (character != 'l'
                    && character != 'L'
                    && character != 'd'
                    && character != 's')
                {
                    return false;
                }

            }

            foreach (var character in lengthStr)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
                var length = Convert.ToInt32(lengthStr);
            }
            return true;
        }
        private static void ShowHelpText()
        {
            Console.WriteLine(@"
                   Options: <length> <chars>
                    - l = lower case letter
                    - L = upper case letter
                    - d = digit
                    - s = special character(!#¤%&(){}[] 
                   Example: PasswordGenerator 14 lLssdd

                            Min. 1 lower case

                            Min. 1 upper case

                            Min. 2 special characters

                            Min. 2 digits");
            
        }

    }
}
