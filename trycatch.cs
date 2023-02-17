using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class divideloop
    {
        public void startLoop()
        {
            Console.WriteLine("두 행렬의 곱 프로그램 시작");
        }
        public void endLoop()
        {
            Console.WriteLine("두 행렬의 곱 프로그램 종료");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            divideloop dv = new divideloop();
            dv.startLoop();
            int[] arr1 = { 100, 200, 300, 400, 1500, 700, 1300 };
            int[] arr2 = { 1, 2, 4, 5, 0};
            for(int op1 = 0; op1 < arr1.Length; op1++)
            {
                for(int op2 = 0; op2 <arr2.Length; op2++)
                {
                    try
                    {
                        Console.WriteLine(arr1[op1] + " / " + arr2[op2] + " = " + arr1[op1] / arr2[op2]);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("0으로 나눠지는 수가 있음");
                        Console.WriteLine("분모에 0이 있으니 수정할 것");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("프로그램에 문제가 있으니 수정할 것");
                    }
                }
            }
            dv.endLoop();
        }
    }
}
