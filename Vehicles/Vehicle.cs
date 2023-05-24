namespace Vehicles;

public class Vehicle
{
    protected string make;
    protected string model;
    protected string year;

    public Vehicle()
    {
    }
    public Vehicle(string make, string model, string year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    public string Make
    {
        set { make = value; }
        get { return make; }
    }
    public string Model
    {
        set { model = value; }
        get { return model; }
    }
    public string Year
    {
        set { year = value; }
        get { return year; }
    }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating vehicle");
    }
    public void Decelerate()
    {
        Console.WriteLine("Decelerating vehicle");
    }
    public virtual void Drive()
    {
        Console.WriteLine("Driving vehicle");
    }
    public void Start()
    {
        Console.WriteLine("Starting vehicle");
    }
    public void Stop()
    {
        Console.WriteLine("Stopping vehicle");
    }
}