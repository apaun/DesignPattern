namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new ConcreteAdapter(new ConcreteAdaptee());
            adapter.Operation();
        }
    }
}
