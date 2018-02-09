using System;
using System.Collections.Generic;
using System.Linq;
namespace problem_solving_using_stack
{
    public class ParansMatcher
    {
        private static Dictionary<char, char> matchingOpens;
        private static HashSet<char> openParans;


        static ParansMatcher()
        {
            matchingOpens = new Dictionary<char, char>();
            matchingOpens.Add(']', '[');
            matchingOpens.Add('}', '{');
            matchingOpens.Add('>', '<');
            matchingOpens.Add(')', '(');

            openParans = new HashSet<char>();

            foreach (KeyValuePair<char, char> item in matchingOpens)
                openParans.Add(item.Value);
        }

        /// <summary>
        /// Complexity of this code is O(N)
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool HasMatchingParans(string expression)
        {
            try
            {
                Stack.Stack<char> openPanransFound = new Stack.Stack<char>();

                foreach (char expressionChar in expression)
                {
                    if (openParans.Contains(expressionChar))
                        openPanransFound.PUSH(expressionChar);

                    if (matchingOpens.ContainsKey(expressionChar))
                    {
                        if (openPanransFound.GetSize() == 0)
                            return false;

                        if (!matchingOpens.TryGetValue(expressionChar, out char openForTheCloseFound) ||
                            !openPanransFound.POP().Equals(openForTheCloseFound))
                        {
                            return false;
                        }
                    }
                }

                return openPanransFound.IsEmpty();
            }
            catch (Stack.StackOverflowException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Stack.StackUnderflowException ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }
    }
}
