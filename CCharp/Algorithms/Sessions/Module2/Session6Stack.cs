using Algorithms.Assignment.Module2;

namespace Algorithms.Sessions.Module2
{
    public class Session6Stack
    {
        // 1. implementation of stack using array
        // 2. implementation of stack using linked list
        
        /// <summary>
        /// Easy
        /// Source: https://leetcode.com/problems/valid-parentheses/
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            if(string.IsNullOrEmpty(s))
                return false;

            var stackP = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stackP.Push(c);
                }
                else if (c == '}')
                {
                    if (stackP.Count == 0 || stackP.Pop() != '{')
                        return false;
                }
                else if (c == ']')
                {
                    if (stackP.Count == 0 || stackP.Pop() != '[')
                        return false;
                }
                else if (c == ')')
                {
                    if (stackP.Count == 0 || stackP.Pop() != '(')
                        return false;
                }
            }

            return stackP.Count == 0;
        }

        /// <summary>
        /// 150. Evaluate Reverse Polish Notation
        /// Source: https://leetcode.com/problems/evaluate-reverse-polish-notation/
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public int EvalRPN(string[] tokens)
        {
            var operations = new HashSet<string>()
            {
                "+",
                "-",
                "*",
                "/"
            };
            int result = 0;
            var stack = new Stack<int>();

            for (var i = 0; i < tokens.Length; i++)
            {

                if (operations.Contains(tokens[i]))
                {
                    var operator1 = stack.Pop();
                    var operator2 = stack.Pop();
                    if (tokens[i] == "+")
                        result = operator1 + operator2;
                    else if (tokens[i] == "-")
                        result = operator1 - operator2;
                    else if (tokens[i] == "*")
                        result = operator1 * operator2;
                    else if (tokens[i] == "/")
                        result = operator1 / operator2;
                    stack.Push(result);
                    continue;
                }

                stack.Push(Convert.ToInt32(tokens[i]));
            }

            return stack.Peek();
        }
    }
}
