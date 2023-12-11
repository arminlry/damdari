//armin liryaee
// damdari tamrin 8
public sealed class Cow : Animal
    {
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int MaxLife { get; set; }
    public List<environments> Environment { get; set; }
    public List<product> Product { get; set; }
    public List<Cost> cost { get; set; }
    public double Weight { get; set; }
    public bool Gender { get; set; }
    public double StressFactor(environments environments)
        {
        double stressFactor = 0;
        stressFactor += environments.TDS.StressFactor()
              + environments.Temp.StressFactor()
              + environments.Density.StressFactor()
              + environments.db.StressFactor()
              + environments.AQI.StressFactor()
              + environments.OX.StressFactor();
        return (double)Math.Round(stressFactor / (double)6, 2);
    }
    public override int life()
    {
        double life = 0;
        foreach (environments environments in environments)
        { 
            life += StressFactor(environments);
        }
        return (int)Math.Floor(life);
    }
    public override int TimeToDie()
    {
        double RL = (MaxLife * 365) - life();
        return (int)RL;
    }
    public override double KillPriority()
    {
        int killing = (MaxLife * 365) - life();
        double kill = 0;
        double v = killing switch
        {
            >= 5000 => 0,
            >= 3285 => 0.25,
            >= 1825 => 0.50,
            >= 730 => 0.75,
            <= 730 => 1,
        };
        double rr = v;
        return kill;
    }
    public override decimal CostPerDay()
    {
        decimal costs = 0;
        foreach (Cost Cost in cost)
        {
            costs += (decimal)Cost.Price * (decimal)Cost.Daily;
        }
        return costs;
    }
    public override decimal ValuePerDay()
    {
        decimal value = 0;
        foreach (product Product in Product)
        {
            value += Product.Price + (decimal)Product.Daily;
        }
        return value;
    }

    public override double StressFactor()
    {
        throw new NotImplementedException();
    }
}
