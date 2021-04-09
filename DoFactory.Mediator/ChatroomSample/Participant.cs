namespace DoFactory.Mediator.ChatroomSample
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Participant
    {
        public string Name { get; }
        public ChatRoomBase ChatRoom { get; set; }
        
        public Participant(string name)
        {
            this.Name = name;
        }

        public void Send(string to, string message)
        {
            ChatRoom.Send(this.Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            System.Console.WriteLine($"{from} sends to {this.Name}: {message}");
        }
    }

    public class Beatle : Participant
    {
        public Beatle(string name) : base(name)
        {

        }

        public override void Receive(string from, string message)
        {
            System.Console.Write("To a beatle => ");
            base.Receive(from, message);
        }
    }

    public class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name)
        {

        }

        public override void Receive(string from, string message)
        {
            System.Console.Write("To a non beatle => ");
            base.Receive(from, message);
        }
    }
}