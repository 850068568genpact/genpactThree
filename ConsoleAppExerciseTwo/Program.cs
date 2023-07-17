using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciseTwo
{
    public class ValidationException : Exception
    {
        public ValidationException(string msg) : base(msg) { }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Registration");
                Console.WriteLine("Enter your name (atleast 6 characters): ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your Password (atleast 6 characters): ");
                string password = Console.ReadLine();

                //Validate user input

                if (string.IsNullOrEmpty(name))
                {
                    throw new ValidationException("Email is required");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("Password is required");
                }
                else if (name.Length < 6)
                {
                    throw new ValidationException("Name must be atleast 6 characters long");
                }
                else if (password.Length < 6)
                {
                    throw new ValidationException("Password must be atleast 6 characters long");
                }

                //Registration successful

                Console.WriteLine("Registration successful!!!");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { 
                Console.ReadLine();
            }
        }
    }
}

