using BenchmarkDotNet.Attributes;

namespace String_Concatenation
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Test
    {
        private static readonly string Name = "Артем";
        private static readonly string Surname = "Федотов";
        private static readonly string[] Strings = { "Привет, мир и ", Name, " ", Surname };
        private static readonly char[] Chars = { 'П', 'р', 'и', 'в', 'е', 'т', ',', ' ', 'м', 'и', 'р', ' ', 'и', ' ', 'А', 'р', 'т', 'е', 'м', ' ', 'Ф', 'е', 'д', 'о', 'т', 'о', 'в' };
        private static readonly List<string> List = ["Привет, мир и ", Name, " ", Surname];

        [Benchmark]
        public void Interpolation()
        {
            string c = StringConcatenation.Interpolation(Name, Surname);
        }
        [Benchmark]
        public void Concatenation()
        {
            string c = StringConcatenation.Concatenation(Name, Surname);
        }
        [Benchmark]
        public void Concat()
        {
            string c = StringConcatenation.Concat(Name, Surname);
        }
        [Benchmark]
        public void Join()
        {
            string c = StringConcatenation.Join(Strings);
        }
        [Benchmark]
        public void Format()
        {
            string c = StringConcatenation.Format(Name, Surname);
        }
        [Benchmark]
        public void Builder()
        {
            string c = StringConcatenation.Builder(Name, Surname);
        }
        [Benchmark]
        public void StringFromCharArray()
        {
            string c = StringConcatenation.StringFromCharArray(Chars);
        }
        [Benchmark]
        public void JoinList()
        {
            string c = StringConcatenation.JoinList(List);
        }
    }
}
