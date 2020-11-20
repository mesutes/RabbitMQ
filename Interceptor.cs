using Castle.Core;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQMail
{
    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {      
                Console.WriteLine(invocation.Method.Name + " isimli methoddan tetiklendi");
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu : " + ex.Message);
            }

        }


    }
}
