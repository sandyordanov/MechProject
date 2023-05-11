namespace Classes
{
    public class Repair
    {
        private FromSystem _system;
        private string _description;
        private double _price;

        public Repair(FromSystem system, string description)
        {
            _system = system;
            _description = description;
        }
        public void SetPrice(double price)
        {
            _price = price;
        }

    }
}