using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation tempOperation = null;

            switch (operate)
            {
                case "+":
                    tempOperation = new OperationAdd();
                    break;
                case "-":
                    tempOperation = new OperationSub();
                    break;
                case "*":
                    tempOperation = new OperationMul();
                    break;
                //进行相应的异常处理
                case "/":
                    tempOperation = new OperationDiv();
                    break;
                default:
                    throw new Exception("输入的符号不正确");
                    break;
            }

            return tempOperation;
        }
    }
}
