using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string [] hobbies;

    //contructor
    public  Profile (string name,int age,string city,string country,string pronouns="they/them" )
    {
      this.name = name;
      this.age = age;
      this.city=city;
      this.country=country;
      this.pronouns=pronouns;
      this.hobbies= new string[0];
    }

    //method
    public string ViewProfile() 
    { 
      string bio = $" Name: {this.name}\n age:{this.age}\n City:{this.city}\n Country:{this.country}\n pronouns:{this.pronouns}\n Hobbies: \n ";

    
      foreach (string hobby in hobbies)
      { bio += $" - {hobby}\n ";} 

      return bio;              
   }
  
  public void SetHobbies(string[]hobbies)
  {
    this.hobbies = hobbies;
  }
  }
}