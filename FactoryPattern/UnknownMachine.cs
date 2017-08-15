namespace Domain.FactoryPatterns
{
    public class UnknownMachine : IMachine
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }
    }
}