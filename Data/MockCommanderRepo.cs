using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>()
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Small pot"},
                new Command{Id=1, HowTo="Cut bread", Line="Bread knife", Platform="Cutting board"},
                new Command{Id=3, HowTo="Make Tea", Line="Boil Water", Platform="Kettle and tea-pot "}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle and pan"};
        }
    }
}
