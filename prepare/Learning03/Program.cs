using System;

class Program
{
    static void Main(string[] args)
    {
    //Console.WriteLine("Hello Learning03 World!");
    Fraction Fraction1 = new Fraction();
    Console.WriteLine(Fraction1.GetFractionString());
    Console.WriteLine(Fraction1.GetDecimalValue());

    Fraction Fraction2 = new Fraction(5);
    Console.WriteLine(Fraction2.GetFractionString());
    Console.WriteLine(Fraction2.GetDecimalValue());

    Fraction Fraction3 = new Fraction(3, 4);
    Console.WriteLine(Fraction3.GetFractionString());
    Console.WriteLine(Fraction3.GetDecimalValue());

    Fraction Fraction4 = new Fraction(1, 3);
    Console.WriteLine(Fraction4.GetFractionString());
    Console.WriteLine(Fraction4.GetDecimalValue());
    
    }
    public class Fraction{
        private int _numerator;
        private int _denominator;

        public Fraction(){ // default value
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int wholeNumber){
            _numerator = wholeNumber;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator){
            _numerator = numerator;
            _denominator = denominator;
        }

        public string GetFractionString(){
            string output = $"{_numerator}/{_denominator}";
            
            return output;
        }
        public double GetDecimalValue(){//This is for getting the result for decimal numbers
            return (double)_numerator/(double)_denominator;
        }
    }
    
}