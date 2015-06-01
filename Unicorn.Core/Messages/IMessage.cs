namespace Unicorn.Core.Messages
{
    public interface IMessage
    {
        MessageType Type { get; }

        byte[] Data { get; }
    }
}
