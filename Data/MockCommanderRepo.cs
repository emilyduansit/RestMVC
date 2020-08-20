using System.Collections.Generic;
using Commander.Models;


namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0,   HowTo="boil an egg", Line="boil water",Platform="cat"},
                new Command{Id=1,   HowTo="boil two egg", Line="boil water",Platform="cat"},
                new Command{Id=2,   HowTo="boil three egg", Line="boil water",Platform="cat"}
            };

            return commands;
        }

        public Command GetCommanderByID(int id)
        {
            return new Command{Id=0,   HowTo="boil an egg", Line="boil water",Platform="cat"};
        }
    }
}