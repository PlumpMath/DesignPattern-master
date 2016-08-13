using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //命名要用有意义的英文，前面可以加上表示类型的修饰词
            while (true)
            {
                try
                {
                    Console.Write("请输入数字:");
                    string strNumber1 = Console.ReadLine();
                    Console.Write("请输入运算符号:");
                    string strOprate = Console.ReadLine();
                    Console.Write("请输入数字:");
                    string strNumber2 = Console.ReadLine();

                    string strResult = null;
                    Operation mOperation = OperationFactory.CreateOperation(strOprate);
                    mOperation.Number1 = Convert.ToDouble(strNumber1);
                    mOperation.Number2 = Convert.ToDouble(strNumber2);
                    strResult = mOperation.Operate().ToString();
                    Console.WriteLine("计算结果为:" + strResult);

                    break;
                }
                catch
                {
                    Console.WriteLine("出现异常了呢!QAQ");
                }
            }
            Console.ReadKey();
        }
    }
}
