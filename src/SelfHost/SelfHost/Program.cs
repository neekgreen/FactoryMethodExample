namespace SelfHost
{
    using System;
    using System.Linq;
    using SomeApp;
    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(t => t.AddRegistry<DefaultRegistry>());

            var tenant1 = new Tenant { TenantId = "diamond", CommonName = "Diamond Tenant" };
            var tenant2 = new Tenant { TenantId = "ruby", CommonName = "Ruby Tenant" };
            var tenant3 = new Tenant { TenantId = "onyx", CommonName = "Onyx Tenant" };

            var factory = container.GetInstance<IEmailContentBuilderFactory>();
            var builder1 = factory.GetBuilder(tenant1);
            var builder2 = factory.GetBuilder(tenant2);
            var builder3 = factory.GetBuilder(tenant3);

            var result1 = builder1.GenerateContent(tenant1);
            var result2 = builder2.GenerateContent(tenant2);
            var result3 = builder3.GenerateContent(tenant3);

            Console.WriteLine(result1.MessageBody);
            Console.WriteLine(result2.MessageBody);
            Console.WriteLine(result3.MessageBody);
        }
    }
}