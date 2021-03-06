﻿using System;
using System.IO;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace GettingStartedHost
{
  internal class Program
  {

    #region Properties
    //private static Uri _baseAddress;

    //public static Uri baseAddress
    //{
    //  get { return _baseAddress; }
    //  set { _baseAddress = value; }
    //}


    //private static ServiceHost _selfHost;

    //public static ServiceHost svcHost
    //{
    //  get { return _selfHost; }
    //  set { _selfHost = value; }
    //}

    //private static ServiceMetadataBehavior _smb;

    //public static ServiceMetadataBehavior smb
    //{
    //  get { return _smb; }
    //  set { _smb = value; }
    //}

    #endregion Properties


    private static void w(string s)
    {
      using (StreamWriter sw = File.AppendText("log.txt"))
      {
        sw.WriteLine(DateTime.Now.ToShortTimeString() + " - " + s);
      }
    }
    private static void Main(string[] args)
    {
      ///Step 1 - Creates an instance of the Uri class to hold the base 
      ///address of the service. Services are identified by a URL which 
      ///contains a base address and an optional URI.The base address is 
      ///formatted as follows:[transport]://[machine-name or domain][:optional port #]/[optional URI segment]
      ///The base address for the calculator service uses the HTTP transport, 
      ///localhost, port 8000, and the URI segment "GettingStarted"
      Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");
      w(baseAddress.ToString());


      ///Step 2 – Creates an instance of the ServiceHost class to host the service. 
      ///The constructor takes two parameters, the type of the class that 
      ///implements the service contract, and the base address of the service.
      ServiceHost svcHost = new ServiceHost(typeof(CalculatorService), baseAddress);

      try
      {

        ServiceMetadataBehavior smb = svcHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
        if (smb == null)
        {
          smb = new ServiceMetadataBehavior();
        }

        smb.HttpGetEnabled = true;
        smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
        svcHost.Description.Behaviors.Add(smb);
        // Add MEX endpoint
        svcHost.AddServiceEndpoint(
          ServiceMetadataBehavior.MexContractName,
          MetadataExchangeBindings.CreateMexHttpBinding(),
          "mex"
        );
        // Add application endpoint
        svcHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

        /////Step 3 – Creates a ServiceEndpoint instance. 
        /////A service endpoint is composed of an address, a binding, and a service contract. 
        /////The ServiceEndpoint constructor therefore takes the service contract interface type, 
        /////a binding, and an address. 
        /////The service contract is ICalculator, which you defined and 
        /////implement in the service type. 
        /////The binding used in this sample is WSHttpBinding 
        /////which is a built-in binding that is used for connecting to endpoints that conform 
        /////to the WS-* specifications. For more information about WCF bindings, 
        /////see WCF Bindings Overview. 
        /////The address is appended to the base address to 
        /////identify the endpoint. The address specified in this code is "CalculatorService" 
        /////so the fully qualified address for the endpoint is "http://localhost:8000/GettingStarted/CalculatorService".
        //svcHost.AddServiceEndpoint(typeof(ICalculator),
        //  new WSHttpBinding(), "CalculatorService");





        /////Step 4 – Enable metadata exchange. 
        /////Clients will use metadata exchange to generate proxies that will be used to call the service operations. 
        /////To enable metadata exchange create a ServiceMetadataBehavior instance, 
        /////set it’s HttpGetEnabled property to true, 
        /////and add the behavior to the System.ServiceModel.ServiceHost.Behaviors* 
        /////collection of the ServiceHost instance.
        //ServiceMetadataBehavior smb;
        //smb = svcHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
        //if (smb == null)
        //{
        //  smb = new ServiceMetadataBehavior
        //  {
        //    HttpGetEnabled = true,
        //    HttpsGetEnabled = true
        //  };

        //}
        //svcHost.Description.Behaviors.Add(smb);
        //Binding binding = MetadataExchangeBindings.CreateMexHttpBinding();
        //svcHost.AddServiceEndpoint(typeof(IMetadataExchange), binding, "MEX");





        ///Step 5 – Open the ServiceHost to listen for incoming messages. 
        ///Notice the code waits for the user to hit enter. 
        ///If you do not do this, the app will close immediately and the service will shut down.
        ///Also notice a try/catch block used. 
        ///After the ServiceHost has been instantiated, all other code is placed in a try/catch block. 
        ///For more information about safely catching exceptions thrown by ServiceHost, 
        ///see Use Close and Abort to release WCF client resources
        svcHost.Open();
        Console.WriteLine("The service is ready: " + Assembly.GetEntryAssembly().GetName().Version.ToString());
        Console.WriteLine("Press <Any Key> to terminate service.");
        Console.WriteLine();
        Console.ReadKey();

        // Close the ServiceHostBase to shutdown the service.
        svcHost.Close();
      }
      catch (CommunicationException ce)
      {
        Console.WriteLine("An exception occurred: {0}", ce.Message);
        svcHost.Abort();
      }
    }
  }
}
