using System;

namespace FootballPlayer
{
    public class FBPlayer
    {
        private int _shirtNumber;
        private string _name;
        public int Id { get; set; }
        public int price { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 3) throw new ArgumentOutOfRangeException();
                {
                    _name = value;
                }
            }
        }
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value <= 1 || value >= 100) throw new ArgumentOutOfRangeException();
                {
                    _shirtNumber = value;
                }
            }
        }

        public FBPlayer(string name, int shirtnumber, int id, int price)
        {
            _name = name;
            _shirtNumber = shirtnumber;
        }

    }
}
