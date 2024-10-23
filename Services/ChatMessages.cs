public class ChatMessages
{
    public record Message(string Name, string Text);

    List<Message> _messages = new List<Message>();

    public void AddMessage(Message message)
    {
        _messages.Add(message);
    }

    public List<Message> GetAllMessages()
    {
        return _messages;
    }
}