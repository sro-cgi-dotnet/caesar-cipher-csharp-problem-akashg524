using System;
using System.Linq;
using System.Text;
namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder result=new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int temp=text[i];
                if(Enumerable.Range(Convert.ToInt32('A'),26).Contains(temp))
                {
                    temp=temp+shiftKey-Convert.ToInt32('A');
                    temp=temp%26;
                    temp+=Convert.ToInt32('A');
                    result.Append((char)temp);
                }
                else if(Enumerable.Range(Convert.ToInt32('a'),26).Contains(temp))
                {
                    temp=temp+shiftKey-Convert.ToInt32('a');
                    temp=temp%26;
                    temp+=Convert.ToInt32('a');
                    result.Append((char)temp);
                }
                else
                {
                    result.Append((char)temp);
                }
            }
            return result.ToString();//to convert stringbuilder to string type
        }
    }
}
