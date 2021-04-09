using System.Collections.Generic;

namespace DoFactory.Mediator.ChatroomSample
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class ChatRoomBase
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    public class ChatRoom : ChatRoomBase
    {
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
                participant.ChatRoom = this;
            }
        }

        public override void Send(string from, string to, string message)
        {
            _participants[to]?.Receive(from, message);
        }
    }
}
