using System;

namespace planner
{
  public class Building
  {
    // Private fields/properties
    private string _designer { get; set; }

    private DateTime _dateConstructed { get; set; }

    private string _address { get; set; }

    private string _owner { get; set; }

    // Public Properties
    public int Stories { get; set; }

    public double Width { get; set; }

    public double Depth { get; set; }

    // Read-Only Public Property
    public string Volume
    {
      get
      {
        return $"{(3 * Stories) * Width * Depth}";
      }
    }

    // Constructor
    public Building(string address)
    {
      _address = address;
    }

    // Public Methods
    public void Construct(string name)
    {
      _dateConstructed = DateTime.Now;
      _designer = name;
    }

    public void Purchase(string owner)
    {
      _owner = owner;
    }

    public void DisplayBuildingInfo()
    {
      Console.WriteLine(_address);
      Console.WriteLine("----------------");
      Console.WriteLine($"Designed by {_designer}");
      Console.WriteLine($"Constructed on {_dateConstructed}");
      Console.WriteLine($"Owned by {_owner}");
      Console.WriteLine($"{Volume} cubic meters of space");
    }

  }
}