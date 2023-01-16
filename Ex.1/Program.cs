namespace Ex._1
{



    internal class Program
    {
        internal class WrongLoginException : Exception
        {
            public WrongLoginException() : base("Wrong login!") { }
            public WrongLoginException(string message) : base(message) { }
        }

        internal class WrongPasswordExeception : Exception
        {
            public WrongPasswordExeception() : base("Wrong password") { }

            public WrongPasswordExeception(string message) : base(message) { }
        }


        internal class Authorization
        {
            private string _login;
            private string _password;

            public Authorization(string login, string password, string confirmPassword)
            {
                if (AuthorizationChecking(login, password, confirmPassword))
                {
                    _login = login;
                    _password = password;
                }

                Console.WriteLine("LogIn");
            }

            public static bool AuthorizationChecking(string login, string password, string confirmPassword)
            {
                if (login.Length > 20 || login.Any(s => s.Equals(" ")))
                {
                    throw new WrongLoginException("Password should be without any spaces " +
                        "and should contains only 20 simbols or less");
                }
               
                
                if (password.Length > 20 | !password.Any(s => char.IsDigit(s))
                    
)
                { 
                    throw new WrongPasswordException("Wrong password!");
                }

                if (password.Contains(' ')) 
                {
                    throw new WrongPasswordException("Wrong password!");
                }
                 return true;
                
            }
             
            //public static bool PasswordChecking(string password)
            //{
            //    foreach (char item in password)
            //    {
            //        if (char.IsDigit(item))
            //        { 
            //            return true; 
            //        }
                    
                       
            //    }
            //    return false;
               
            //}



        }

        static void Main(string[] args)

        {   
            try
            { 
                Authorization aut = new Authorization("VicMur", "AAAAAAA A1", "AAAAAAA A1");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }
           
        }

    }
}