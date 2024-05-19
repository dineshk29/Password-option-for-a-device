using System.Runtime.Serialization;

namespace  System
{
    class A
    {

        public static void Main(string[] args)
        {
            int s, c = 0, p, p1, e = 0, r, p2 = 0, d = 0;
            string dp, dp1;
           
            Console.WriteLine("         WELCOME LOGIN PAPGE         ");
            Console.WriteLine();
            Console.WriteLine("SELECT DEVICE:  1\n1.MOBILE  \n2.WINDOWS");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {   
            X: Console.Write("SET YOUR PASSWORD:");
                p = Convert.ToInt32(Console.ReadLine());
                p2 = p2 + p;
                while (p > 0)
                {
                    r = p % 10;
                    p = (p / 10);
                    e = e + 1;
                }
                Console.WriteLine(e);
                while (true)
                { 
                    if (e == 4 || e == 6)
                    {
                        while (c <= 3)
                        {
                        Z1: Console.Write("ENTER YOUR PASSWORD:");
                            p1 = Convert.ToInt32(Console.ReadLine());
                            if (p1 == p2)
                            {  
                                Console.WriteLine("LOGIND SUCCESSFULLY");
                                goto Z;
                            }
                            else
                            {
                                Console.WriteLine("RETRY PUSHPAA......");
                                c = c + 1;
                            }
                            if (c == 4)
                            {
                                //Thread.Sleep(3000);
                                for (int j = 10; j >= 0; j--)
                                {
                                    Console.WriteLine(" TRY AFTER    " + j);
                                    Thread.Sleep(1000);    
                                } 
                            }
                            goto Z1;
                        }
                    Z: break;
                    }
                    else
                    {
                        Console.WriteLine("ENTER PASS BETWEEN 4 2 6 DIGITS ONLY");
                        e = 0;
                        p2 = 0;
                        goto X;
                    }
                }
            }
            else if (s == 2)
            {
               Console.Write("SET DESKTOP PASSWORD:");
                dp = Console.ReadLine();
                while (d <= 3)
                {
                Z2: Console.Write("Enter your password:");
                    dp1 = Console.ReadLine();
                    if (dp == dp1)
                    {
                        Console.WriteLine("LOGIND SUCCESSFULLY");
                        break;
                    }
                    else
                    { 
                        Console.WriteLine("MALLI TRY CHEY GURU.......");
                        d = d + 1;
                    }
                    if (d == 5)
                    {
                        //Thread.Sleep(3000);
                        for (int i = 5; i >= 0; i--)
                        {
                            Console.WriteLine("remaining    " + i);
                            Thread.Sleep(1000);    
                        }
                    }
                    goto Z2;
                    break;
                }
                //Thread.Sleep(3000);
                d = 0;
            }
            else
            {  
                Console.Write("ENTER CORRECT CHOICE:");
            }
        }
    }
}