﻿//armin liryaee
// damdari tamrin 8
public struct product : Product
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public decimal Price { get; set; }
    public double Daily { get; set; }
    public override string ToString() => $"Name={Name}\n Daily={Daily}{Unit}\n Price={Price}";
}
