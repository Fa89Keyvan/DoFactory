using DoFactory.Mediator.ChatroomSample;
using System;

namespace DoFactory.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoBaseSample();
            Console.WriteLine();
            Console.WriteLine();
            DemoChatRoom();
        }

        static void DemoBaseSample()
        {
            Console.WriteLine(nameof(DemoBaseSample));
            Console.WriteLine("=============================");

            var mediator = new BaseSample.ConctreteMediator();

            var colleague1 = new BaseSample.ConcreteColleague1(mediator);
            var colleague2 = new BaseSample.ConcreteColleague2(mediator);

            mediator.SetColleague1(colleague1);
            mediator.SetColleague2(colleague2);

            colleague1.Send("Hi. how are you?");
            colleague2.Send("Fine, thanks");

            Console.ReadLine();
        }

        static void DemoChatRoom()
        {
            Console.WriteLine(nameof(DemoChatRoom));
            Console.WriteLine("=============================");

            // Create chatroom

            ChatRoomBase chatroom = new ChatRoom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
