using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!,-'/`_*$";
      Console.WriteLine("Enter password: ");
      string password = Console.ReadLine();
      int score = 0;
      if ((score) >= (minLength))
      {
        score++;
      }
      
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
           
      Console.WriteLine("Entered Password is: " + password);
      Console.WriteLine("Score of the password is: " + score);
      
      switch (score) 
      {
        case 5:
        case 4:
          Console.WriteLine("This is an extremely strong password");
          break;
        case 3:
          Console.WriteLine("This is a strong password");
          break;
        case 2:
          Console.WriteLine("This is an average password");
          break;
        case 1:
          Console.WriteLine("This is a weak password");
          break;
        default:
          Console.WriteLine("This password doesn't meet the standards");
          break;
      } 
      Console.ReadLine();
    }
  }
}