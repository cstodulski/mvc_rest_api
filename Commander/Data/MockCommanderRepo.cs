using System.Collections.Generic;
using Commander.Models;
using System;

namespace Commander.Data 
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            // if(cmd == null)
            // {
            //     throw new ArgumentNullException(nameof(cmd));
            // }


        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{ Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{ Id=1, HowTo="Cut a bread", Line="Get a knife", Platform="Tabble & Knife"},
                new Command{ Id=2, HowTo="make a cup of tea", Line="put teabag in the cup", Platform="Kettle & Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}