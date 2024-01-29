namespace Amnesty
{
    class Criminal
    {
        public Criminal(string surname, string name, string patronymic, string crime)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Crime = crime;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Crime { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} преступление: {Crime}");
        }
    }
}