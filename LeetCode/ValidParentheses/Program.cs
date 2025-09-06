namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid(")(){}"));
        }

        public static bool IsValid(string s)
        {
            if (s.Length < 2)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            char[] _closeParentheses = [']', ')', '}'];
            char[] _openParentheses = ['[', '(', '{'];
            foreach (char c in s)
            {
                if (_openParentheses.Contains(c))
                {
                    stack.Push(c);
                }

                if (_closeParentheses.Contains(c))
                {
                    if (stack.Count > 0)
                    {
                        char lastItem = stack.Pop();
                        switch (c)
                        {
                            case ')':
                                if (lastItem != '(')
                                    return false;
                                break;

                            case '}':
                                if (lastItem != '{')
                                    return false;
                                break;
                            case ']':
                                if (lastItem != '[')
                                    return false;
                                break;
                            default:
                                return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            return stack.Count == 0;
        }
    }
}