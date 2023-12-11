//armin liryaee
// damdari tamrin 8
public struct healathParameter<T> : HealthParameter<T>
{
    public string Name { get; set; }
    public T Current { get; set; }
    public T Standard { get; set; }
    public double Zarib { get; set; }
    public double StressFactor()
    {
        double result = Convert.ToDouble(Current) / Convert.ToDouble(Standard);
        return Math.Round(result * Zarib, 2);
    }
    public override string ToString()
    {
        return $"ParameterName={Name}\nStandard={Standard}\nCurrent={Current}";
    }
}
