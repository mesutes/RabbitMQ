using Castle.Core;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MailConsumer;
using MailPublisher;
using RabbitMQ.Client;
using System;


namespace RabbitMQMail
{
    class Program
    {
        private static WindsorContainer container;
        static void Main(string[] args)
        {

            container = new WindsorContainer();

            container.Register(Component.For<Interceptor>().Named("test"));
            container.Register(Component.For<ITest>().ImplementedBy<Test>().Interceptors(InterceptorReference.ForKey("test")).Anywhere);

            ITest c = container.Resolve<ITest>();

            c.test();


            //DependencyResolver.Initialize();

            //resolve the type:Rocket
            //   var test = DependencyResolver.For<ITest>();




            Console.ReadKey();

            ///*bağlantı bilgileri tanımlanıyor*/
            //string UserName = "guest";
            //string Password = "guest";
            //string HostName = "localhost";

            //var connectionFactory = new RabbitMQ.Client.ConnectionFactory()
            //{
            //    UserName = UserName,
            //    Password = Password,
            //    HostName = HostName
            //};

            //var connection = connectionFactory.CreateConnection();
            //var model = connection.CreateModel();


            //PublisherService ps = new PublisherService(model);

            //string SecimMenu = string.Empty;
            //string MailTo = string.Empty;
            //string MailBody = string.Empty;
            //String MailType = string.Empty;


            //do
            //{
            //    Console.WriteLine("Menü");
            //    Console.WriteLine("1 - Kuyruğa yeni mail ekle");
            //    Console.WriteLine("2 - Kuyrukları tüketmeye başla");
            //    Console.WriteLine("3 - Çıkış");
            //    Console.WriteLine("Kuyruktaki bekleyen mesaj sayısı(Gmail) = " + model.MessageCount("GmailQuee"));
            //    Console.WriteLine("Kuyruktaki bekleyen mesaj sayısı(Outlook) = " + model.MessageCount("OutlookQuee"));

            //    SecimMenu = Console.ReadLine();

            //    if (SecimMenu == "1")
            //    {
            //        Console.WriteLine("Mail Alıcı : ");
            //        MailTo = Console.ReadLine();
            //        Console.WriteLine("Mail İçerik : ");
            //        MailBody = Console.ReadLine();
            //        Console.WriteLine("Mail Tip (1-Gmail 2-Outlook) : ");
            //        MailType = Console.ReadLine();

            //        ps.SendMailQuee((PublisherService.MailType)int.Parse(MailType), MailBody, MailTo);

            //    }
            //    else if (SecimMenu == "2") 
            //    {
            //        GMailConsumer gmailconsumer = new GMailConsumer(model);
            //        OutlookConsumer outlookConsumer = new OutlookConsumer(model);

            //    }

            //} while (SecimMenu != "3");





        }

    }
}
