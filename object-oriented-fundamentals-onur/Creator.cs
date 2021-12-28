using System;

namespace object_oriented_fundamentals_onur
{
    public abstract class Creator
    {
        private int _creativityLevel = 100;
        private int _energy = 100;

        public int CreativityLevel
        {
            get
            {
                return _creativityLevel;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _creativityLevel = value;
                }
                else
                {
                    throw new Exception("Creativity level can only be a between 0 and 100.");
                }
            }
        }
        
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    throw new Exception("Energy level can only be a between 0 and 100.");
                }
            }
        }
        public abstract void Create();
    }
}