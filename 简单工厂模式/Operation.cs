using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//面向对象三大特征 封装 继承 多态

namespace DesignPattern
{
    class Operation
    {
        private double number1;
        public double Number1 { get; set; }

        private double number2;
        public double Number2 { get; set; }

        //抽象方法，由子类继承
        public  virtual double Operate()
        {
            double result = 0;
            return result;
        }
    }

    class OperationAdd : Operation
    {
        public override double Operate()
        {
            double result = 0;
            result = Number1 + Number2;
            return result;
        }
    }

    class OperationSub : Operation
    {
        public override double Operate()
        {
            double result = 0;
            result = Number1 - Number2;
            return result;
        }
    }

    class OperationMul : Operation
    {
        public override double Operate()
        {
            double result = 0;
            result = Number1 * Number2;
            return result;
        }
    }

    class OperationDiv : Operation
    {
        public override double Operate()
        {
            double result = 0;
            if (Number2 == 0)
            {
                throw new Exception("除数为0");
            }
            result = Number1 / Number2;   
            return result; 
        }
    }

}
