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
                int temp=Convert.ToInt32(text[i]);
                if(Enumerable.Range(65,26).Contains(temp))
                {
                    temp=temp+shiftKey-65;
                    temp=temp%26;
                    temp+=65;
                    result+=(char)temp;
                }
                else if(Enumerable.Range(97,26).Contains(temp))
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
