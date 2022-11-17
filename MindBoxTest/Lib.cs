namespace MindBoxTest
{
    public interface ITwoDimensionalFigure
    {
        public double Area { get; }
    }

    public interface IAreaCalculator
    {
        public long CalculateArea(double ITwoDimensionalFigure);
    }

    public class Circle : ITwoDimensionalFigure
    {
        public double _radius { get; private set; }
        public double Area
        {
            get => Math.PI * Math.Pow(_radius, 2);
        }

        public Circle(double radius)
        {
            _radius = radius;
        }
    }

    public class Triangle : ITwoDimensionalFigure
    {
        public bool IsIsosceles { get; private set; } = false;
        public bool IsRight { get; private set; } = false;
        public bool IsExist { get; private set; } = false;
        private double _a, _b, _c;

        public double Area
        {
            get
            {
                return AreaCount(_a, _b, _c);
            }
        }

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            if (TriangleExist(a, b, c))
            {
                IsExist = true;
                if (a == b || a == c || b == c)
                {
                    IsIsosceles = true;
                }

                if (!IsIsosceles)
                {
                    IsRight = RightCheck(a, b, c);
                }
            }
            else
            {
                throw new Exception("Треугольника не существует!");
            }
        }

        private double AreaCount(double a, double b, double c)
        {
            var semiperimeter = (a + b + c) / 2;
            double area =
            semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c);
            return Math.Sqrt(area);
        }

        private bool RightCheck(double a, double b, double c)
        {
            var sides = new List<double> { a, b, c };
            double legsSum = 0;
            sides.Sort();
            sides.Reverse();
            var hypotenuse = sides.Max();
            sides.RemoveAt(0);

            foreach (var elem in sides)
            {
                legsSum += Math.Pow(elem, 2);
            }

            if (Math.Pow(hypotenuse, 2) == legsSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TriangleExist(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
