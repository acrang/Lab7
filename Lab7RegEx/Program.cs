using System;
using System.Text.RegularExpressions;

namespace Lab7RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            bool validName = ValidName(name);
            Console.WriteLine(validName);

            Console.WriteLine("Please enter your email address: ");
            string email = Console.ReadLine();

            bool validEmail = ValidEmail(email);
            Console.WriteLine(validEmail);

            Console.WriteLine("Please enter your phone number: ");
            string phone = Console.ReadLine();

            bool validPhone = ValidPhone(phone);
            Console.WriteLine(validPhone);

            Console.WriteLine("Please enter a date (DD/MM/YYYY): ");
            string date = Console.ReadLine();

            bool validDate = ValidDate(date);
            Console.WriteLine(validDate);

        }

        public static bool ValidName(string name)
        {
            Regex regex = new Regex(@"^([A-Z][a-z]+([ ][A-Z][a-z]+)*)$");
            return regex.IsMatch(name);
        }
        public static bool ValidEmail(string email)
        {
            Regex regex = new Regex(@"^([A-Z|a-z|0-9](\.|_){0,1})+[A-Z|a-z|0-9]\@([A-Z|a-z|0-9])+((\.){0,1}[A-Z|a-z|0-9]){1}\.[a-z]{2,3}$");
            return regex.IsMatch(email);
        }
        public static bool ValidPhone(string phone)
        {
            Regex regex = new Regex(@"^([0-9]\d{9})|(\d{1}\d{1}\d{1}-\d{1}\d{1}\d{1}-\d{1}\d{1}\d{1}\d{1})$");
            return regex.IsMatch(phone);
        }
        public static bool ValidDate(string date)
        {
            Regex regex = new Regex(@"^(([1-2][0-9])|([1-9])|(3[0-1]))/((1[0-2])|([1-9]))/[0-9]{4}$");
            return regex.IsMatch(date);
        }
    }
}
