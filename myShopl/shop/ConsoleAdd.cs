namespace myShopl.shop
{
    public class ConsoleAdd : Position
    {
        private string _port;
        private string _gamepad;
        private decimal _weithConsole = 100;

        public string Gamepad { get { return _gamepad; }set { _gamepad = value; } }
        public string Port { get { return _port; }set { _port = value; } }
        public override decimal Weigth { get { return _weithConsole; } set { _weithConsole = value; } }
    };
}