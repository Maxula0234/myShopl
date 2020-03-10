namespace myShopl.shop
{
    public abstract class Computer : Position
    {
        private decimal _ram;
        private decimal _screen;
        private bool _hdd;
        private bool _ssd;
        private decimal _cpu;
        private decimal _gpu;
        private string _system;

        public decimal Ram { get { return _ram; } set { _ram = value; } }
        public decimal Screen { get { return _screen; } set { _screen = value; } }
        public bool Hdd { get { return _hdd; } set { _hdd = value; } }
        public bool Ssd { get { return _ssd; } set { _ssd = value; } }
        public decimal Cpu { get { return _cpu; } set { _cpu = value; } }
        public decimal Gpu { get { return _gpu; } set { _gpu = value; } }
        public string System { get { return _system; } set { _system = value; } }

    }
}