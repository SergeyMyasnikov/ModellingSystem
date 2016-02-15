using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModellingSystem
{
    public abstract class RandomGenerator
    {
        public string Name;
        public RandomGenerator(string name)
        {
            Name = name;        }

        abstract public double nextDouble();
        protected Random r = new Random();
    }

    public class Uniform : RandomGenerator
    {
        private int _a;
        private int _b;

        public Uniform (int a, int b) : base("равномерное")
        {
            _a = a;
            _b = b;
        }

        public override double nextDouble()
        {
            return r.NextDouble() * (_b - _a) + _a;
        }
    }

    public class Normal : RandomGenerator
    {
        private int _M;
        private int _D;

        public Normal(int M, int D) : base("нормальное")
        {
            _M = M;
            _D = D;
        }

        public override double nextDouble()
        {
            double n1 = 2 * r.NextDouble() - 1;
            double n2 = 2 * r.NextDouble() - 1;
            double s = n1 * n1 + n2 * n2;
            while ((s > 1) || (s == 0))
            {
                n1 = 2 * r.NextDouble() - 1;
                n2 = 2 * r.NextDouble() - 1;
                s = n1 * n1 + n2 * n2;
            }
            double x = n1 * Math.Sqrt(-2 * Math.Log(s) / s) * _D + _M;
            return x;
        }
    }

    public class Exponential : RandomGenerator
    {
        private int _M;

        public Exponential(int M) : base("экспоненциальное")
        {
            _M = M;
        }

        public override double nextDouble()
        {
            return -Math.Log(r.NextDouble()) * _M; ;
        }
    }

    public class Triangle : RandomGenerator 
    {
        private int _a;
        private int _b;
        private int _moda;

        public Triangle(int a, int b, int moda) : base("треугольное")
        {
            _a = a;
            _b = b;
            _moda = moda;
        }

        public override double nextDouble()
        {
            double x = r.NextDouble();
            if ((x >= 0) && (x <= (_moda - _a) / (_b - _a)))
                x = _a + Math.Sqrt((_moda - _a) * (_b - _a) * x);
            else if ((x > (_moda - _a) / (_b - _a)) && (x <= 1))
                x = _b - Math.Sqrt((_b - _moda) * (_b - _a) * (1 - x));
            return x;
        }
    }
}