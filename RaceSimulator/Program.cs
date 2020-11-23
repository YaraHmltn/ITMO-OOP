using System;

namespace RaceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Race<NanTransport> NewRace = new Race<NanTransport> (20000);


            Broom broom = new Broom();
            MagicCarpet magicCarpet = new MagicCarpet();
            Mortar mortar = new Mortar();

            Centaur centaur = new Centaur();
            AllTerrainBoots terrainBoots = new AllTerrainBoots();
            BactrianCamel bactrianCamel = new BactrianCamel();
            SpeedyCamel speedyCamel = new SpeedyCamel();

            NewRace.NewParticipant(centaur);
            NewRace.NewParticipant(terrainBoots);
            NewRace.NewParticipant(bactrianCamel);
            NewRace.NewParticipant(speedyCamel);

            NewRace.NewParticipant(mortar);
            NewRace.NewParticipant(broom);
            NewRace.NewParticipant(magicCarpet);

            Console.WriteLine(NewRace.GetWinner().Name);
        }
    }
}
