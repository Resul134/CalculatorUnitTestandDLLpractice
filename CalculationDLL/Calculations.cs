using System;

namespace CalculationDLL
{
    public class Calculations
    {
        private double _minusse;
        private double _plusse;
        private double _divider;
        private double _multiplicer;


        #region Encapsulation


        public double Multiplicer
        {
            get { return _multiplicer; }
            set { _multiplicer = value; }
        }

        public double Divider
        {
            get { return _divider; }
            set
            {
                CheckDivider(_divider); _divider = value; }
        }

        public double Plusse
        {
            get { return _plusse; }
            set { CheckPlus(_plusse );
                _plusse = value;
            }
        }

        public double minusse
        {
            get { return _minusse; }
            set { _minusse = value; }
        }


        #endregion

        public Calculations()
        {
        }
        

        public double Plus(double Plus, double PlusVærdi2)
        {
            double Sætsammen = Plus;
            double Sæt = PlusVærdi2;
            return Plus + PlusVærdi2;
        }


        public double Minus(double minus, double minus2)
        {
            return minus - minus2;
        }

        public double Multiply(double mul1, double mul2)
        {
            return mul1 * mul2;
        }


        public double Divide(double div1,double div2)
        {
            return div1 / div2;
        }


        public void CheckDivider(double divVærdi)
        {
            if (divVærdi == 0 && divVærdi < 0)
            {
                throw new ArgumentException("Den må ikke være minus, eller dividers med nul");

            }

        }

        public void CheckPlus(double plusVærdi)
        {
            if (plusVærdi <= 0)
            {
                throw new ArgumentException("Man må ikke taste minus tal ind");
            }

        }

        public void CheckMinus(double minusVærdi)
        {
            if (minusVærdi.Equals(0))
            {
                throw new ArgumentException("Du må ikke indtaste nul værdier");
            }
        }

        public void checkMultipliy(double mulVærdi)
        {
            if (mulVærdi <= 0)
            {
                throw new ArgumentException("Du skal ikke gange med nul, du får nul");
            }
        }
    }
}
