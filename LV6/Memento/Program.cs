using Memento.ToDos;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            RunToDoDemo();
        }

        private static void RunToDoDemo()
        {
            ToDoItem toDoItem = new ToDoItem(
                "Buy bread",
                "deder pls",
                new DateTime(2021, 5, 7, 13, 55, 55)
            );
            Memento.ToDos.Memento memento = toDoItem.StoreState();
            CareTaker careTaker = new CareTaker();
            careTaker.Save("Bread", memento);

            Console.WriteLine(toDoItem);
            toDoItem.Rename("nebi, a?");
            Console.WriteLine(toDoItem);
            careTaker.Save("nece", toDoItem.StoreState());

            toDoItem.RestoreState(careTaker.GetState("Bread"));
            Console.WriteLine(toDoItem); 
            toDoItem.RestoreState(careTaker.GetState("nece"));
            Console.WriteLine(toDoItem);
        }
    }
}
