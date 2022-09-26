using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class EvaluateReversePolish
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> data = new Stack<int>();
            HashSet<string> operators = new HashSet<string>() { "+", "-", "/", "*" };
            var res = 0;
            foreach (var item in tokens)
            {
                if(operators.Contains(item))
                {
                    var op2 = data.Pop();
                    var op1 = data.Pop();
                   
                    switch (item)
                    {
                        case "+":
                            res = op1 + op2;
                            break;
                        case "-":
                            res = op1 - op2;
                            break;
                        case "*":
                            res = op1 * op2;
                            break;
                        case "/":
                            res = op1 / op2;
                            break;
                        default:
                            
                            break;
                    }
                    data.Push(res);
                }
                else
                    data.Push(int.Parse(item));

            }

            return data.Pop();
        }
    }
}
