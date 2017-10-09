using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogDemo
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("Start Main");
            logger.Debug("Nu kaldes test 1");
            test1(5, 5);
            logger.Debug("retur fra test 1");

            logger.Debug("Nu kaldes test 2");
            test2();
            logger.Debug("retur fra test 2");

            logger.Trace("Exit Main");

            Console.ReadKey();
        }

        static void test1(int i, int x)
        {
            //logger.Trace("Enter test1 i,x: {0} , {1}",i,x);
            logger.Trace("Entering " + System.Reflection.MethodBase.GetCurrentMethod().Name + " i, x: { 0} , { 1}",i,x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            logger.Trace("Exit test1");
        }

        static void test2()
        {
            logger.Trace("Enter test2");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
                logger.Error(ex);
            }
            logger.Trace("Exit test2");
        }
    }
}

