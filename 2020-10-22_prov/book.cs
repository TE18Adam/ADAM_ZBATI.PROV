using System;

namespace _2020_10_22_prov
{
   
    public class instans
    {
       
        public string bookName;
        private int actualValue;
        private int rarity;
        public int price;
        public string category;

        public int Evaluate;

        public int cursed;
        bool IsCursed = false;

       
       // En metod som gör alla beräkningar som uppgiften anger. Syftet med metoden är att räkna ut värden för alla ints som finns i parantesen.
        void book(int actualValue, int rarity, int cursed, int Evaluate, int RättPris, int Evaluated )
        {
          // Random generators vars syfte är att randomize massa värden som om boken är cursed, dess rearity och värde.
            Random generator = new Random();
            actualValue = generator.Next(10001);
            rarity = generator.Next(101);
            cursed = generator.Next(5);
            RättPris = generator.Next(2);

            // Evaluate är där bokens värde ska bli evalued genom att multiplicera bokens actual värde med dess rarity,
            Evaluated = rarity * actualValue;
            
            // bestämmer baserat på resulatet av RättPris generatorn om Evaluate ska bli 50% eller 150% av RättPris
            if(RättPris == 1)
            {
                Evaluate = Evaluated / 2;

            }

            if ( RättPris == 0)
            {
                Evaluate = Evaluated * 3 / 2;
            }

           // 2 if satser som säger att det finns 20% chans att IsCrsed boolen är true och 80% chans att den stannar false
            if(cursed > 0)
            {
                IsCursed = false;
                
            }
            
            if(cursed == 0)
            {
                IsCursed = true;
                
            }

            
          

        }

    }
}
