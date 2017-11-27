using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ExtensionMethodlar
{
    public static string YaziyiDuzelt(this string str)
    {
        str = str.Trim();
        str = str.ToUpper();
        return str;
    }

    public static bool IsNumeric(this string str)
    {
        try
        {
            foreach (char item in str)
                if (!char.IsDigit(item))
                    return false;
        }
        catch
        {
            return false;
        }
        return true;
    }

    public static string StringYap(this object obj)
    {
        if (obj == null)
            return null;
        try
        {
            return obj.ToString();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}

