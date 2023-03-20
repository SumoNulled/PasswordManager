using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Classes.Passwords
{
    internal class Password
    {
        private static String encryptionKey = "I&w@eMl$R1I8y817&JFVHJ0gmEXG8YSDXr8NGVh0XtIk*^K#6fs1&6keZJ5SDGzDxWyQ3Of169YhwWBbsPlF&nUV6bKQICiqGVgt";
        private static char[] encryptionKeyChars = encryptionKey.ToCharArray();
        private static int[] key = new int[encryptionKeyChars.Length];


        private static Random rand;
        static Password()
        {
            rand = new Random();
            for (int i = 0; i < encryptionKeyChars.Length; i++)
            {
                key[i] = Convert.ToInt32(encryptionKeyChars[i]);
            }
        }
        public static String Encrypt(String plaintext)
        {
            char[] a = plaintext.ToCharArray();
            int[] b = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Convert.ToInt32(a[i]);
            }

            for(int i = 0; i < b.Length; i++)
            {
                b[i] += key[i];
            }

            for(int i = 0; i< a.Length; i++)
            {
                a[i] = (char)b[i];
            }

            String result = String.Join("", a);
            return "$0kb$" + result;
        }

        public static String Decrypt(String encrypted)
        {
            encrypted = encrypted.Remove(0, 5);

            char[] c = encrypted.ToCharArray();
            int[] d = new int[c.Length];

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = Convert.ToInt32(c[i]);
                d[i] -= key[i];
                c[i] = (char)d[i];
            }

            String result = String.Join("",c);
            return result;
        }

        public static String GetKey()
        {
            return encryptionKey;
        }

        public static String Generate(int length, bool uppercase = true, bool lowercase = true, bool numbers = true, bool symbols = true)
        {
            string character_set = "";
            string str = "";
            if (uppercase)
                character_set += GetUppercaseSet();

            if (lowercase)
                character_set += GetLowercaseSet();

            if (numbers)
                character_set += GetNumbersSet();
            
            if (symbols)
                character_set += GetSymbolsSet();

            var character_setRandomize = 
                character_set.ToCharArray().OrderBy(item => rand.Next());

            char[] characters = character_setRandomize.ToArray();
            try
            {
                for (int i = 0; i < length; i++)
                {
                    str += characters[rand.Next(0, characters.Length - 1)];
                }
            } catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select at least one checkbox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return str;
        }

        private static String GetUppercaseSet()
        {
            List<char> uppercase = new List<char>();
            for(int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                uppercase.Add((char)i);
            }
            
            var result = uppercase.OrderBy(item => rand.Next());

            String str = new string(result.ToArray());
            return str;
        }

        private static String GetLowercaseSet()
        {
            List<char> uppercase = new List<char>();
            for (int i = Convert.ToInt32('a'); i <= Convert.ToInt32('z'); i++)
            {
                uppercase.Add((char)i);
            }
            
            var result = uppercase.OrderBy(item => rand.Next());

            String str = new string(result.ToArray());
            return str;
        }

        private static String GetNumbersSet()
        {
            List<char> numbers = new List<char>();
            for (int i = Convert.ToInt32('0'); i <= Convert.ToInt32('9'); i++)
            {
                numbers.Add((char)i);
            }

            var result = numbers.OrderBy(item => rand.Next());

            String str = new string(result.ToArray());
            return str;
        }

        private static String GetSymbolsSet()
        {
            List<char> symbols = new List<char>();
            List<char> not_allowed = new List<char> { '\'', '\"', '`', ',', '\\', '/'};

            for (int i = Convert.ToInt32('!'); i <= Convert.ToInt32('/'); i++)
            {
                if (!not_allowed.Contains(Convert.ToChar(i)))
                symbols.Add((char)i);
            }

            for (int i = Convert.ToInt32(';'); i <= Convert.ToInt32('@'); i++)
            {
                if (!not_allowed.Contains(Convert.ToChar(i)))
                    symbols.Add((char)i);
            }

            var result = symbols.OrderBy(item => rand.Next());

            String str = new string(result.ToArray());
            return str;
        }
    }
}
