using System.Collections.Generic;
using System.Linq;

namespace ProjectPatterns.Mediator.Chat
{
    public class ChatRoom
    {
        private List<Person> _people = new List<Person>();

        public void Broadcast(string source, string message)
        {
            foreach (var person in _people)
            {
                if (person.Name != source)
                {
                    person.Receive(source, message);
                }
            }
        }

        public void Join(Person person)
        {
            string joinMessage = $"{person.Name} joins the chat";
            Broadcast("room", joinMessage);
            person.Room = this;
            _people.Add(person);
        }

        public void Message(string source, string destination, string message)
        {
            _people.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
        }
    }
}