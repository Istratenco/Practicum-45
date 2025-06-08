using System;

namespace GenericsExample
{
    // Задание 1
    class TransportCompany<T>
    {
        public T Power { get; set; }
        public double Cost { get; set; }
        public string Brand { get; set; }

        public TransportCompany(T power, double cost, string brand)
        {
            Power = power;
            Cost = cost;
            Brand = brand;
        }

        public void Print()
        {
            Console.WriteLine($"[TransportCompany] Power: {Power}, Cost: {Cost}, Brand: {Brand}");
        }
    }

    // Задание 2
    class DoubleTypes<T1, T2>
    {
        private T1 var1;
        private T2 var2;

        public DoubleTypes(T1 v1, T2 v2)
        {
            var1 = v1;
            var2 = v2;
        }

        public void Print()
        {
            Console.WriteLine($"[DoubleTypes] var1: {var1}, var2: {var2}");
        }
    }

    // Задание 3.1
    class Calculator<T> where T : struct
    {
        public T Add(dynamic a, dynamic b) => a + b;
        public T Subtract(dynamic a, dynamic b) => a - b;
        public T Multiply(dynamic a, dynamic b) => a * b;
        public T Divide(dynamic a, dynamic b) => b != 0 ? a / b : throw new DivideByZeroException();
    }

    // Задание 3.2
    class Calculator<T1, T2>
    {
        public dynamic Add(T1 a, T2 b) => (dynamic)a + (dynamic)b;
        public dynamic Subtract(T1 a, T2 b) => (dynamic)a - (dynamic)b;
        public dynamic Multiply(T1 a, T2 b) => (dynamic)a * (dynamic)b;
        public dynamic Divide(T1 a, T2 b) => (dynamic)b != 0 ? (dynamic)a / (dynamic)b : throw new DivideByZeroException();
    }

    // Задание 4
    class Point<T>
    {
        private T x;
        private T y;

        public Point(T xValue, T yValue)
        {
            x = xValue;
            y = yValue;
        }

        public T X
        {
            get => x;
            set => x = value;
        }

        public T Y
        {
            get => y;
            set => y = value;
        }

        public void Print()
        {
            Console.WriteLine($"[Point] X = {x}, Y = {y}");
        }
    }

    // Главный метод
    class Program
    {
        static void Main()
        {
            Console.WriteLine("== Задание 1: TransportCompany ==");
            var plane1 = new TransportCompany<int>(1200, 5000000, "Boeing");
            var plane2 = new TransportCompany<double>(1450.5, 7000000, "Airbus");
            var plane3 = new TransportCompany<string>("High", 4500000, "Sukhoi");
            plane1.Print();
            plane2.Print();
            plane3.Print();

            Console.WriteLine("\n== Задание 2: DoubleTypes ==");
            var doubleType = new DoubleTypes<int, string>(123, "Example");
            doubleType.Print();

            Console.WriteLine("\n== Задание 3.1: Calculator<T> ==");
            var calc1 = new Calculator<double>();
            Console.WriteLine($"Add: {calc1.Add(5.5, 2.5)}");
            Console.WriteLine($"Subtract: {calc1.Subtract(10, 3)}");
            Console.WriteLine($"Multiply: {calc1.Multiply(2, 4)}");
            Console.WriteLine($"Divide: {calc1.Divide(9, 3)}");

            Console.WriteLine("\n== Задание 3.2: Calculator<T1, T2> ==");
            var calc2 = new Calculator<int, double>();
            Console.WriteLine($"Add: {calc2.Add(5, 2.5)}");
            Console.WriteLine($"Subtract: {calc2.Subtract(10, 3.5)}");
            Console.WriteLine($"Multiply: {calc2.Multiply(2, 4.0)}");
            Console.WriteLine($"Divide: {calc2.Divide(9, 3.0)}");

            Console.WriteLine("\n== Задание 4: Point<T> ==");
            var point1 = new Point<int>(5, 10);
            var point2 = new Point<double>(3.5, 7.2);
            point1.Print();
            point2.Print();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
