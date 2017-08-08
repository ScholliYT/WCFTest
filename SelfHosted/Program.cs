﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHosted
{
    public class TestService : ITestService
    {

        public double geteilt(double _a, double _b)
        {
            if (Math.Abs(_b) > 0)
            {
                return _a / _b;
            }
            throw new Exception("Teiler darf nicht null sein");
        }

        public double mal(double _a, double _b)
        {
            return _a * _b;
        }

        public double minus(double _a, double _b)
        {
            return _a - _b;
        }

        public double plus(double _a, double _b)
        {
            double answer = _a + _b;
            Console.WriteLine("Got new {0} request. {1} + {2} = {3}", "plus", _a, _b, answer);
            return answer;
        }
    }

    [ServiceContract]
        public interface ITestService
        {
            [OperationContract]
            double plus(double _a, double _b);

            [OperationContract]
            double minus(double _a, double _b);

            [OperationContract]
            double mal(double _a, double _b);

            [OperationContract]
            double geteilt(double _a, double _b);
        }

    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:12345/rechner");
            using (ServiceHost host = new ServiceHost(typeof(TestService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
