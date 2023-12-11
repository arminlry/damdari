//armin liryaee
// damdari tamrin 8
public abstract class Animal
    {
        static Animal() { TotalNumber = 0; }
        public Animal()
        {
            TotalNumber++;
            Number = TotalNumber;
        }
        public static int TotalNumber { get; private set; }
        public int Number { get; private set; }
        public double Weight { get; set; }
        public bool IsMale { get; set; }
        public List<Environment> environments { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract double StressFactor();
        public abstract int life();
        public abstract int TimeToDie();
        public abstract double KillPriority();
        public abstract decimal CostPerDay();
        public abstract decimal ValuePerDay();
    }
