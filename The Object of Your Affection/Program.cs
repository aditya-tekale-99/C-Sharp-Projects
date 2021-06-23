using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile tom = new Profile("Tom Drew",22,"New york","USA","he/him");
     
     tom.SetHobbies(new string [] {"listening to audiobooks and podcasts","playing rec sports like bowling and kickball","writing a speculative fiction novel","reading advice columns"});

     Console.WriteLine(tom.ViewProfile());

    }
  }
}