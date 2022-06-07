using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCredit = new ConsumerCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();
            ICreditManager businessCreditManager = new BusinessCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService, fileLoggerService };
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(businessCreditManager, loggers);

            List<ICreditManager> creditManagers = new List<ICreditManager> { consumerCredit, transportCreditManager };
            // applicationManager.MakeACreditPreInformation(creditManagers);
        }
    }
}
