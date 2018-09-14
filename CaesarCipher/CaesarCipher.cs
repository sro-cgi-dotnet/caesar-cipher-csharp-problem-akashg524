using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string result="";
            for (int i = 0; i < text.Length; i++)
            {
                int temp=text[i];
                if(Enumerable.Range(Convert.ToInt32('A'),26).Contains(temp))
                {
                    temp=temp+shiftKey-65;
                    temp=temp%26;
                    temp+=65;
                    result+=(char)temp;
                }
                else if(Enumerable.Range(Convert.ToInt32('a'),26).Contains(temp))
                {
                    temp=temp+shiftKey-97;
                    temp=temp%26;
                    temp+=97;
                    result+=(char)temp;
                }
                else
                {
                    result+=text[i];
                }
            }
            return result;
        }
    }
}
