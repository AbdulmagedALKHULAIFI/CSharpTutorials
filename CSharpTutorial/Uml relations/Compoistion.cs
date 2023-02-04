using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Uml_relations
{
    //une composition est une agrégation entre objets dont les cycles de vie sont liés.
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    class ElectricalCar
    {
        private Engine engine;

        public ElectricalCar()
        {
            engine = new Engine();
        }

        public void StartEngine()
        {
            engine.Start();
        }
    }

    class ProgramCompoisition
    {
        static void Main(string[] args)
        {
            ElectricalCar car = new ElectricalCar();
            car.StartEngine();
            Console.ReadLine();
        }
    }

}
