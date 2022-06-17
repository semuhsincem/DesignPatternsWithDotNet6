namespace Mediator
{
    //Mediator pattern is used to reduce communication complexity between multiple objects or classes.
    //This pattern provides a mediator class which normally handles
    //all the communications between different classes and supports easy maintenance of the code by loose coupling.
    public class User
    {
        private string Name { get; set; }

        public User(string name)
        {
            Name= name;
        }

        public string GetName()
        {
            return Name;
        }

        public string SendMessage(string message)
        {
            return ChatRoom.SendMessage(this,message);
        }
    }
}