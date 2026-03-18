
namespace G_NET_20_ADVC_1
{
    internal class Container<T>
    {
        public Container()
        {
        }

        internal void Add(string v)
        {
            throw new NotImplementedException();
        }

        internal string Get(int v)
        {
            throw new NotImplementedException();
        }
    }
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public void Deconstruct(out TFirst first, out TSecond second)
        {
            first = First;
            second = Second;
        }
    }
}