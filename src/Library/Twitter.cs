using TwitterUCU;
using System;

namespace Library
{
    public class Twitter: IMessageChannel
    {
        public void Send(Message message)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
        }
        public Message GetMessage(Contact from, Contact to)
        {
            Message message = new TwitterMessage(from.Id, to.Id);
            return message;
        }
    }
}