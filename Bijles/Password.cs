using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijles
{
    public class Password
    {
        private string password = "";
        private Random random = new Random();

        /// <summary>
        /// Generate a random password
        /// </summary>
        /// <param name="capitals"></param>
        /// <param name="noncapitals"></param>
        /// <param name="digits"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public string CreateRandomPassword(
            int capitals, int noncapitals, int digits, int other)
        {
            if (digits == 0 || capitals == 0 || noncapitals == 0 ||
                other == 0)
            {
                throw new Exception(
                    "The password must have at least one character per category!");
            }
            if (digits + capitals + noncapitals + other < 6)
            {
                throw new Exception(
                    "The password must have at least six characters!");
            }
            // Add digits to the password
            AddDigits(digits);

            return password;
        }

        /// <summary>
        /// Add [numberOfDigits] digits to the password
        /// </summary>
        /// <param name="numberOfDigits"></param>
        private void AddDigits(int numberOfDigits)
        {
            for (int i = 0; i < numberOfDigits; i++)
            {
                int randomnumber = random.Next(0, 10);
                password += randomnumber.ToString();
            }
        }
    }
}
