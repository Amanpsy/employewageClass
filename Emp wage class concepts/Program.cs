using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_project
{
    public class Calculator

    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result = (num1 + num2);
            
        }

        void Subtract()
        {
            result = (num1 - num2);
           
        }

        void divide()
        {
            result = (num1 / num2);
            
        }

        void multiply()
        {
            result = (num1 * num2);
        }
            
        void DisplayResult()
        {
            Console.WriteLine("result is :- " +result);
            Console.ReadLine();
        }

        public static void Main(string[] args)

        {
            Calculator obj = new Calculator();
            obj.num1 = 10;
            obj.num2 = 20;
            
            obj.Subtract();
            obj.DisplayResult();
            obj.Add();
            obj.DisplayResult();
            
         
           //Calculator obj1 = new Calculator();
            obj.num1 = 45;
            obj.num2 = 66;
            obj.Add();
            obj.Subtract();

        }


    }
}
