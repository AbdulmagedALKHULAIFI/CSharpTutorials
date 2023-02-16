using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Uml_relations
{

    //In this example, the Car class depends on the Logger class. This represents a dependency relationship,
    //as the Car class cannot function without an instance of the Logger class.

    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging message: " + message);
        }
    }

    class Car
    {
        private Logger logger;

        public Car(Logger logger)
        {
            this.logger = logger;
        }

        public void StartEngine()
        {
            logger.Log("Engine started");
        }
    }

    class Dependency
    {
        public Dependency(string[] args)
        {
            Logger logger = new Logger();
            Car car = new Car(logger);
            car.StartEngine();
            Console.ReadLine();
        }
    }


}
