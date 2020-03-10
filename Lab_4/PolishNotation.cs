using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    static class PolishNotation
    {
        static private List<char> separators = new List<char>()
        {
            '+', '-', '*', '/', '%'
        };
        static private List<Literal> literals = new List<Literal>();

        static private void CreateLiterals(string input)
        {
            bool is_neg = false;
            string literal = "";
            int number;
            for (int i = 0; i < input.Length; i++)
            {
                if (separators.Contains(input[i])) {
                    if (input[i] == '-' && i == 0)
                    {
                        is_neg = true;
                        continue;
                    }
                    try
                    {
                        number = is_neg ? -(Convert.ToInt32(literal)) : Convert.ToInt32(literal);
                        is_neg = false;
                    }
                    catch (System.FormatException)
                    {
                        throw new CalculationException("Incorrect expression");
                    }
                    literal = "";
                    literals.Add(new Literal(number));
                    switch (input[i])
                    {
                        case '+': literals.Add(new Literal(Operation.ADD)); break;
                        case '-': literals.Add(new Literal(Operation.SUB)); break;
                        case '*': literals.Add(new Literal(Operation.MUL)); break; 
                        case '/': literals.Add(new Literal(Operation.DIV)); break;
                        case '%': literals.Add(new Literal(Operation.MOD)); break;
                    }
                }
                else
                {
                    literal += input[i];
                }
            }
            try
            {
                literals.Add(new Literal(Convert.ToInt32(literal)));
            }
            catch (System.FormatException)
            {
                throw new CalculationException("Incorrect expression");
            }
        }

        static private int GetPriority(Operation operation)
        {
            if (operation == Operation.ADD || operation == Operation.SUB)
            {
                return 1;
            }
            else
                return 2;
        }

        static private void ToPolish()
        {
            Stack<Literal> stack = new Stack<Literal>();
            Stack<Literal> stack2 = new Stack<Literal>();
            bool intexas = true;
            foreach (var i in literals)
            {
                if (i.type == Type.NUMBER)
                {
                    stack.Push(i);

                }
                else
                {
                    while (intexas)
                    {
                        int priority;
                        if (stack2.Count() == 0)
                            priority = 3;
                        else
                            priority = GetPriority(stack2.Peek().operation);
                        switch (GetPriority(i.operation))
                        {
                            case 1:
                                if (priority == 3)
                                {
                                    stack2.Push(i);
                                    intexas = false;
                                }
                                else
                                {
                                    stack.Push(stack2.Pop());
                                    intexas = true;
                                }
                                break;
                            case 2:
                                if (priority == 3 || priority == 1)
                                {
                                    stack2.Push(i);
                                    intexas = false;
                                }
                                else
                                {
                                    stack.Push(stack2.Pop());
                                    intexas = true;
                                }
                                break;
                        }
                    }
                }
                intexas = true;
            }
            while (stack2.Count() != 0)
                stack.Push(stack2.Pop());
            literals = stack.Reverse().ToList();
        }

        static private int GetResult()
        {
            Stack<Literal> stack = new Stack<Literal>();
            Queue<Literal> queue = new Queue<Literal>(literals);
            Literal lit = queue.Dequeue();
            try
            {
                while (queue.Count >= 0)
                {
                    if (lit.type == Type.NUMBER)
                    {
                        stack.Push(lit);
                        lit = queue.Dequeue();
                    }
                    else
                    {
                        int summ = 0;
                            checked
                            {
                                switch (lit.operation)
                                {

                                    case Operation.ADD:
                                        {
                                            int a = stack.Pop().value;
                                            int b = stack.Pop().value;
                                            summ = b + a;
                                            break;
                                        }
                                    case Operation.SUB:
                                        {
                                            int a = stack.Pop().value;
                                            int b = stack.Pop().value;
                                            summ = b - a;
                                            break;
                                        }
                                    case Operation.MUL:
                                        {
                                            int a = stack.Pop().value;
                                            int b = stack.Pop().value;
                                            summ = a * b;
                                            break;
                                        }
                                    case Operation.DIV:
                                        {
                                            int a = stack.Pop().value;
                                            int b = stack.Pop().value;
                                            summ = b / a;
                                            break;
                                        }
                                    case Operation.MOD:
                                        {
                                            int a = stack.Pop().value;
                                            int b = stack.Pop().value;
                                            summ = b % a;
                                            break;
                                        }
                                }
                            }
                        stack.Push(new Literal(summ));
                        if (queue.Count > 0)
                            lit = queue.Dequeue();
                        else
                            break;
                    }

                }
                return stack.Pop().value;
            }
            catch (System.InvalidOperationException ex)
            {
                return lit.value;
            }
            catch (System.OverflowException ex)
            {
                throw new CalculationException("Overflow");
            }
            catch(System.DivideByZeroException ex)
            {
                throw new CalculationException("Zero division");
            }
            finally
            {
                literals.Clear();

            }
        }
        
        static public int Perform(string input) {
                CreateLiterals(input);
                ToPolish();
                return GetResult();
        }
    }
}
