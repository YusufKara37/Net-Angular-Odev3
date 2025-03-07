public class Employee
{
     public int Id {get; set;}
    public string Name {get; set;}
    public int Salary {get; set;}
    public string Department {get; set;}

    public virtual decimal CalculateBonus()
    {
        return 0;
    }
}

class Manager:Employee
{
 public int TeamSize {get; set;}

    public override decimal CalculateBonus()
    {
        return Salary*0.20m;
    }

}

class Debeloprt:Employee
{
    public string About {get; set;}

    public override decimal CalculateBonus()
    {
        return Salary*0.10m;
    }
}