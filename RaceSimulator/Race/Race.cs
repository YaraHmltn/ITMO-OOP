using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    public class Race <RaceType> where RaceType : NanTransport
    {
        public List<RaceType> Participants = new List<RaceType>();

        public double Distance;

        public Race (double distance)
        {
            Distance = distance;
        }

        public void NewParticipant (RaceType transport)
        {
            Participants.Add(transport);
        }

        public RaceType GetWinner()
        {
            if(Participants.Count == 0)
            {
                throw new Exception("Пустая гонка");
            }


            RaceType winner = Participants[0];
            foreach (RaceType transport in Participants)
            {
                
                if (transport.GetTimeRace(Distance) < winner.GetTimeRace(Distance) )
                {
                    winner = transport;
                }
            }
            return winner;
        }
    }
}
