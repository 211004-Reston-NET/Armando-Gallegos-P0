namespace HouseFunction
{
    public class House
    {
        private string terminal;
        private string owner;
        private string gohst;
        private int roomcount;

        public House()
        {
            owner = "Armando";
            terminal = "junk";
            gohst = "Casper";
            roomcount = 1;

    
        }

        public string TerminalInput { get{return terminal;} set{terminal = value;} }
        public string Owner { get{return owner;} set{owner = value; } }
        public string MiceName { get; set; }
    }
}