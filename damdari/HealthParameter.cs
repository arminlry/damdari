//armin liryaee
// damdari tamrin 8
public interface HealthParameter<T>
{
    public string Name { get; set; }
    public T Current { get; set; }
    public T Standard { get; set; }
    public virtual double StressFactor() => Convert.ToDouble(Current) / Convert.ToDouble(Standard);  
}
