using System.Collections.Generic;

namespace Memento.ToDos
{
    class CareTaker
    {
        private Dictionary<string, Memento> history;

        public CareTaker()
        {
            history = new Dictionary<string, Memento>();
        }

        public void Save(string name, Memento memento) => history[name] = memento;
        public Memento GetState(string name) => history[name];
    }
}
