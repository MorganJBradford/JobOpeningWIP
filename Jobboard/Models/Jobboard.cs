// using System;
using System.Collections.Generic;

namespace Jobboard.Models
{
  public class Contacts
  {
    public string Name {get; set;}
    public Contacts(string name)
    {
      Name = name;
      JobOpening._instances.Add(this);
    }
  }
  public class JobOpening
  {
    public string Title {get; set;}
    public string ContactInfo {get; set;}
    public string Description {get; set;}
    public static JobOpening Job {get; set;}
    public static List<Contacts> _instances = new List<Contacts> {};
    public JobOpening(string title, string contact, string desc)
    {
      ContactInfo = contact;
      Title = title;
      Description = desc;
      Job = this;
      
    }

    // public static JobOpening GetJob()
    // {
    //   return _instances[0];
    // }

    //   private static List<Parcel> _instances = new List<Parcel> {};
    //  _instances.Add(this);
  }
}