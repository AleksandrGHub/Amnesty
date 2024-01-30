namespace Amnesty
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Criminal> _criminals = new List<Criminal>();
        private string _antigovernmentCrime = "Антиправительственное";

        public Catalog()
        {
            AddCriminals();
        }

        public void Amnesty()
        {
            _criminals = (_criminals.Where(criminal => criminal.Crime != _antigovernmentCrime)).ToList();

            Console.WriteLine("Прошла амнистия!\n");
        }

        public void ShowInfo()
        {
            foreach (var criminal in _criminals)
            {
                criminal.ShowInfo();
            }

            Console.WriteLine();
        }

        private void AddCriminals()
        {
            int numberCriminals = 10;

            List<string> surnames = new List<string>() { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Михайлов", "Новиков", "Федоров" };
            List<string> names = new List<string>() { "Сергей", "Дмитрий", "Андрей", "Алексей", "Максим", "Иван", "Роман", "Евгений", "Михаил", "Артем" };
            List<string> patronymics = new List<string>() { "Васильевич", "Викторович", "Витальевич", "Кириллович", "Константинович", "Леонидович", "Тимофеевич", "Федорович", "Николаевич", "Олегович" };
            List<string> crimes = new List<string>() { "Побои", "Клевета", "Оскорбления", "Хулиганство", "Вандализм", "Антиправительственное" };

            for (int i = 0; i < numberCriminals; i++)
            {
                _criminals.Add(new Criminal(surnames[_random.Next(surnames.Count)], names[_random.Next(names.Count)], patronymics[_random.Next(patronymics.Count)], crimes[_random.Next(crimes.Count)]));
            }
        }
    }
}