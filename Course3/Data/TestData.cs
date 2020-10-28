using Course3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course3.Data
{
    static class TestData
    {
        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10).Select(i => new Sender
        {
            Name = $"Отправитель {i}",
            Adress = $"sender_{i}@server.ru"
        }).ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10).Select(i => new Recipient
        {
            Name = $"Получатель {i}",
            Adress = $"recipients_{i}@server.ru"
        }).ToList();

        public static List<Server> Servers { get; } = Enumerable.Range(1, 10).Select(i => new Server
        {
            Adress = $"smtp.server{i}.com",
            UseSSL= i%2 == 0
        }).ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 20).Select(i => new Message
        {
            Body = $"Body {i}",
            Subject = $"Subject {i}"
        }).ToList();
    }
}
