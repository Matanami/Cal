using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class NaiveSolution
    {
        private string m_input;
        private List<int> m_numbers = new List<int>();
        private List<char> m_oprators = new List<char>();
        private int m_result;

        public void ConnctionToUser()
        {
            Console.WriteLine("Enter your calculation" );
            m_input = Console.ReadLine();
            foreach (Match match in Regex.Matches(m_input, @"([*+/\-)(])|([0-9]+)"))
            {
                try
                {
                    m_numbers.Add(Convert.ToInt32(match.Value));
                }
                catch
                {
                    m_oprators.Add(Convert.ToChar(match.Value));
                }
            }

        }
        public int Calculat(int i_num1, int i_num2, char i_oprator)
        {
            switch (i_oprator)
            {
                case '+':
                    return  i_num1 + i_num2;
                case '-':
                    return i_num1 - i_num2;
                case '*':
                    return i_num1 * i_num2;
                case '/':
                    return i_num1 / i_num2;
            }
            return 0;
                

        }
        public void SendToCalculat()
        {
            while(m_oprators.Count > 0)
            {
                for (int i = 0;i<m_oprators.Count; i++)
                {
                    if (m_oprators.ElementAt(i) == '+' || m_oprators.ElementAt(i) == '-')
                    {
                        if (m_oprators.Contains('*') || m_oprators.Contains('/'))
                        {
                            continue;
                        }
                    }
                    int temp = Calculat(m_numbers.ElementAt(i), m_numbers.ElementAt(i + 1), m_oprators.ElementAt(i));
                    m_numbers.RemoveRange(i, 2);
                    m_oprators.RemoveAt(i);
                    m_numbers.Insert(i, temp);
                    
                }

            }
            printResult(m_numbers.ElementAt(0));
        }
        public void printResult(int i_result )
        {

            Console.WriteLine($"{m_input} = {i_result}");


        }
    }

}


