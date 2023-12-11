//armin liryaee
// damdari tamrin 8
public class cowparameter : CowParameter
{
    public HealthParameter<int> TimeToStand { get; set; }
    public HealthParameter<int> TimeToDeal { get; set; }
    public HealthParameter<int> TimeToRelax { get; set; }
    public HealthParameter<int> NumberOfMeal { get; set; }
    public HealthParameter<int> NumberOfMilkProduction { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}