using System;
using System.Collections;

namespace IndividualKata
{
    public class Program
    {
        public class PreInf {

            public string Method(string str) {

                if (str == null) {

                    return null;
                }

                Stack stack = new Stack();
                int l = str.Length;

                for (int i = l - 1; i >= 0; i--)
                {
                    char c = str[i];
                    bool v = false;

                    switch (c) {
                        case '+':
                        case '-':
                        case '/':
                        case '*':
                            v = true;
                            break;
                    }


                    if (v)
                    {

                        if (stack.Count == 1)
                        {
                            return null;
                        }

                        string op1 = (string)stack.Pop();
                        string op2 = (string)stack.Pop();

                        string temp = op1 + c + op2;
                        stack.Push(temp);

                    }
                    else {
                        stack.Push(c + "");
                    }
                }

                return (string)stack.Pop();


            }
        

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
