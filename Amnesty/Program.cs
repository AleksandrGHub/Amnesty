namespace Amnesty
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            catalog.ShowInfo();
            catalog.Amnesty();
            catalog.ShowInfo();
        }
    }
}