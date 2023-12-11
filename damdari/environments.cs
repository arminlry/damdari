//armin liryaee
// damdari tamrin 8
public class environments : Environment
{
    public HealthParameter<int> TDS { get; set; }
    public HealthParameter<double> Temp { get; set; }
    public HealthParameter<int> Density { get; set; }
    public HealthParameter<double> db { get; set; }
    public HealthParameter<int> AQI { get; set; }
    public HealthParameter<int> OX { get; set; }
    public DateTime Date { get; set; }
}