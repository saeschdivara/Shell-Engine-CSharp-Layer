namespace Shell.Core
{
    public class Vec2
    {
        public double X
        {
            get;
            set;
        }
        
        public double Y
        {
            get;
            set;
        }

        public Vec2()
        {
            X = 0;
            Y = 0;
        }

        public Vec2(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}