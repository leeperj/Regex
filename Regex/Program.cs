    using System;
    using System.Text.RegularExpressions;

    namespace RegexProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                       
                Console.WriteLine("Please enter your first and last name.");

            string nameInput = Console.ReadLine();
                bool nameResult = VerifyUserName(nameInput);

            Console.WriteLine("Please enter your 10 digit phone number with dashes.");

            string phoneInput = Console.ReadLine();
                bool phoneResult = VerifyPhoneNumber(phoneInput);

            Console.WriteLine("Please enter your email address.");

            string emailInput = Console.ReadLine();
                bool emailResult = VerifyEmail(emailInput);

            Console.WriteLine("Please enter a date in dd/mm/yyyy format.");

            string dateInput = Console.ReadLine();
                bool dateResult = VerifyDate(dateInput);

            Console.WriteLine(nameResult);
                Console.WriteLine(phoneResult);
                Console.WriteLine(emailResult);
                Console.WriteLine(dateResult);
            

            }


            public static bool VerifyEmail(string userEmail)
            {
                bool emailWorks = Regex.IsMatch(userEmail, @"^([a-zA-Z0-9]{5,30})@([a-zA-Z0-9]{5,10})+\.+([a-zA-Z0-9]{2,3})+$");
                if (emailWorks = Regex.IsMatch(userEmail, @"^([a-zA-Z0-9]{5,30})@([a-zA-Z0-9]{5,10})+\.+([a-zA-Z0-9]{2,3})+$"))
                {
                return emailWorks;
                }
            else
            {
                Console.WriteLine("That is not a valid response.");
                return false;
            }
            }
            public static bool VerifyPhoneNumber(string userPhone)
        {
            bool phoneWorks = Regex.IsMatch(userPhone, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
            if (phoneWorks = Regex.IsMatch(userPhone, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$")) 
            {
                return phoneWorks;
            }
            else
            {
                Console.WriteLine("That is not a valid response.");
                return false;
            }
        }

        public static bool VerifyUserName(string userName)
        {


            bool nameWorks = Regex.IsMatch(userName, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
            if (nameWorks = Regex.IsMatch(userName, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                return nameWorks;
            }
            else
            {
                Console.WriteLine("That is not a valid response.");
                return false;
            }
        }

        public static bool VerifyDate(string date)
        {
            bool dateWorks = Regex.IsMatch(date, @"^(\d{2})\/(\d{2})\/(\d{4})$");
            if (dateWorks = Regex.IsMatch(date, @"^(\d{2})\/(\d{2})\/(\d{4})$"))
            {
                return dateWorks;
            }
            else
            {
                Console.WriteLine("That is not a valid response.");
                return false;
            }

        }

       

        }
    }



        
    


