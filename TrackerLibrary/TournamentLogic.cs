using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using System.Linq;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list randomly of teams
        // Check is list is big enough - if not, add in byes - 2^n
        // Create first round of matchups
        // Create every round after that

        public static void CreateRounds(Tournament model)
        {
            List<Team> randomTeamOrder = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomTeamOrder.Count);
            int byes = NumberOfByes(rounds, randomTeamOrder.Count);

            // Error
            model.Rounds.Add(CreateFirstRound(byes, randomTeamOrder));
            
            CreateOtherRounds(model, rounds);
        }
        private static List<Team> RandomizeTeamOrder(List<Team> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }
        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }
        private static List<Matchup> CreateFirstRound(int byes, List<Team> teams)
        {
            List<Matchup> output = new List<Matchup>();
            Matchup curr = new Matchup();

            foreach (Team team in teams)
            {
                curr.Entries.Add(new MatchupEntry { TeamCompeting = team });
                
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new Matchup();
                    
                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }
        private static void CreateOtherRounds(Tournament model, int rounds)
        {
            int round = 2;
            List<Matchup> previousRound = model.Rounds[0];
            List<Matchup> currRound = new List<Matchup>();
            Matchup currMatchup = new Matchup();

            while (round <= rounds)
            {
                foreach (Matchup match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntry { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new Matchup();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<Matchup>();
                round += 1;
            }
        }
    }
}
