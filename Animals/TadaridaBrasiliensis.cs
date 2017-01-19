using System;


namespace Zoolandia.Animals
{
    public class TadaridaBrasiliensis : Animal
    {
        public TadaridaBrasiliensis()
        {
            CanFly = true;
        }
        public TadaridaBrasiliensis (string name)
        {   
            base.Name = name;
        }

        public TadaridaBrasiliensis(int numberOfWings)
        {
            if (numberOfWings > 0)
            {
                CanFly = true;
            }
            else
            {
                CanFly = false;
            }
        }

        public bool CanFly { get; set; }   
    }
}