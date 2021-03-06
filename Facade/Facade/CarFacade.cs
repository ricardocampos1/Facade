using Facade.Subsystems;

namespace Facade.Facade
{
    public class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("************** Creating a Car **************\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();
            Console.WriteLine("\n************** Car Creation complete **************");
        }
    }
}
