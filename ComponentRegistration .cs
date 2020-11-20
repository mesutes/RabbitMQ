using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Text;
using MailConsumer;
using MailPublisher;
using Castle.Core;

namespace RabbitMQMail
{
   public class ComponentRegistration: IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            //kernel.Register(
            //    Component.For<Interceptor>()
            //        .ImplementedBy<Interceptor>());

            kernel.Register(
                Component.For<ITest>()
                         .ImplementedBy<Test>()
                         .Interceptors<Interceptor>(),Component.For<Interceptor>().LifeStyle.Transient);


        }
    }
}
