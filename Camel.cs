using System;
using System.Collections;
using System.Linq;
using System.Text;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        StringBuilder sb = new StringBuilder();

        foreach (var c in str)
        {
            if (char.IsUpper(c))
                sb.Append(' ');

            sb.Append(c);
        }

        return sb.ToString();
    }
}