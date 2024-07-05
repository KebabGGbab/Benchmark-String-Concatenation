using System.Text;

namespace String_Concatenation
{
    internal class StringConcatenation
    {
        public static string Interpolation(string a, string b)
        {
            return $"Привет, мир и {a} {b}";
        }
        public static string Concatenation(string a, string b)
        {
            return "Привет, мир и " + a + " " + b;
        }
        public static string Concat(string a, string b)
        {
            return string.Concat("Привет, мир и ", a, " ", b);
        }
        public static string Join(string[] a)
        {
            return string.Join("", a);
        }
        public static string Format(string a, string b)
        {
            return string.Format("Привет, мир и {0} {1}", a, b);
        }
        public static string Builder(string a, string b)
        {
            return new StringBuilder("Привет, мир и ").Append(a).Append(' ').Append(b).ToString();
        }
        public static string StringFromCharArray(char[] a)
        {
            return new string(a);
        }
        public static string JoinList(List<string> a)
        {
           return string.Join("", a);
        }
    }
}
