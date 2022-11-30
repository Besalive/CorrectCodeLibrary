using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Проверка на коректность кода
        /// </summary>
        /// <param name="candidate">Вводимый код</param>
        /// <returns>Возращает правильность кода</returns>
        public bool IsCorrectCode(string candidate)
        {
            int[] mass = new int[10];
            double sum = 0;
            int k = 0;
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            if (candidate.Length > 10)
            {
                return false;
            }
            else
            {
                if (candidate.Length < 10)
                {
                    return false;
                }
            }
            foreach (char c in candidate)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
                mass[k] = Convert.ToInt32(Char.GetNumericValue(c));
                k++;
            }
            
            for (int i = 0; i < 9; i++)
            {
                sum = sum + mass[i];
            }

            if (sum % 10 == 0 && mass[9] == 0)
            {
                return true;
            }
            else
            {
                if (sum % 3 == 0 && mass[9] == 1)
                {
                    return true;
                }
                else
                {
                    if (mass[9] == 9)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
