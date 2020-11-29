using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{id=0, howto="Boil an egg", line="Boil water", platform="Kettle & Pen"},
                new Command{id=1, howto="Cut bread", line="Get a knife", platform="Knife & cutting board"},
                new Command{id=2, howto="Make cup of tea", line="Place tea bag in cup", platform="Kettle & cup"}   
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{id=0, howto="Boil an egg", line="Boil water", platform="Kettle & Pen"};
        }
    }
}