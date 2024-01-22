namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new Team("SoftUni");

            List<Person> list = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ');

                int age = int.Parse(personInfo[2]);
                decimal salary = decimal.Parse(personInfo[3]);
              
                try
                {
                    Person person = new Person(personInfo[0], personInfo[1], age, salary);
                    team.AddPlayer(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}



