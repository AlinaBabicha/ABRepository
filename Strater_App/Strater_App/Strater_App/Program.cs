using System;
using System.Collections.Generic;

namespace Strater_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int LeftBraces = 0;
            int LeftBrackets = 0;
            int LeftParenth = 0;

            int RightBraces = 0;
            int RightBrackets = 0;
            int RightParenth = 0;

            LinkedList<char> brackets = new LinkedList<char>();
            Console.WriteLine("Please, enter the text");
            var text = Console.ReadLine();

            foreach (char ch in text)
            {
                if (IsLeftBracket(ch))
                    brackets.AddLast(ch);
                else if (IsRightBracket(ch))
                {
                    if (GetRightBracket(brackets.Last.Value) == ch)
                    {
                        brackets.RemoveLast();
                        Console.WriteLine("Brackets are positioned correctly");
                    }
                    else
                        Console.WriteLine("Brackets are positioned incorrectly");
                        foreach (char bracket in text)
                        {
                            if (bracket == '(')
                                LeftBraces++;
                            if (bracket == '[')
                                LeftBrackets++;
                            if (bracket == '{')
                                LeftParenth++;
                            if (bracket == ')')
                                RightBraces++;
                            if (bracket == ']')
                                RightBrackets++;
                            if (bracket == '}')
                                RightParenth++;
                        }

                        Console.WriteLine("Left braces: " + LeftBraces + "\nLeft brackets: " + LeftBrackets + "\nLeft parenthesis: " + LeftParenth + "\nRight braces: " + RightBraces + "\nRight brackets: " + RightBrackets + "\nRight parenthesis: " + RightParenth);

                        if (LeftBraces == RightBraces && LeftBrackets == RightBrackets && LeftParenth == RightParenth)
                        {
                            Console.WriteLine("Braces are correct");
                        }
                        else
                        {
                            Console.WriteLine("Braces are placed incorrectly. Check the amount of right and left ones");
                        }
                    }

            }
            Console.WriteLine("Brackets are in correct positions");

        }

        static bool IsLeftBracket(char ch)
        {
            return ch == '{' || ch == '['
                    || ch == '(';
        }

        static bool IsRightBracket(char ch)
        {
            return ch == '}' || ch == ']'
                    || ch == ')';
        }

        static char GetRightBracket(char bracket)
        {
            if (bracket == '{')
                return '}';
            else if (bracket == '[')
                return ']';
            else if (bracket == '(')
                return ')';
            else
                return ' ';
        }

    }
}
