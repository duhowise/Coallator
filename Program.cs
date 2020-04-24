using System;
using static System.Console;

namespace Coallator {
    class Program {

        static void Main(string[] args) {
            Coallation[] coallatedVotes;

            // enter polling station id
            var pollingStationId = "";
            // number of candidates that contested the election
            var totalNumberOfCandidates = 0;

            // name of electoral commisssioner
            var electoralCommisioner = "";

            var totalVotesCast = 0;

            // last names of each of the candidates and the number of votes received
            WriteLine("Enter the name of the electoral commissioner");
            electoralCommisioner = ReadLine();

            //request the polling Station Id
            WriteLine("Enter the polling Station Id");

            // capture the polling Station Id
            pollingStationId = ReadLine();

            //request the total number of candidates
            WriteLine("Enter the total number of candidates");

            // capture the total number of candidates
            totalNumberOfCandidates = Convert.ToInt32(ReadLine());

            // set array size for the coallated votes
            coallatedVotes = new Coallation[totalNumberOfCandidates];

            // Keep requesting and saving the candidate's last name and total votes until the last one
            for (int numberProcessed = 0; numberProcessed < totalNumberOfCandidates; numberProcessed++) {
                // initialise array for the number of total votes
                var collation = new Coallation();

                WriteLine("Enter the last name of a candidate");
                collation.AddName(ReadLine());
                WriteLine($"Enter votes for '{collation.GetName}'");
                collation.AddVote(Convert.ToInt32(ReadLine()));

                coallatedVotes[numberProcessed] = collation;
                // add this candidates vote to the total votes
                totalVotesCast += collation.GetVotes;
            }

            WriteLine($"Polling Station Id: {pollingStationId}");
            WriteLine($"Electoral Commissioner: {electoralCommisioner}");
            WriteLine();
            // WriteLine("Candidate\tVotes Received\tPercentage of total votes");
            var candidate = "Candidate";
            var votesReceived = "Votes Received";
            var percentVotes = "% of Votes";

            WriteLine($"+ {string.Empty.PrettierPrint( replace : '-')} + {string.Empty.PrettierPrint(replace : '-')} + {string.Empty.PrettierPrint( replace :'-')} +");
            WriteLine($"| {candidate.PrettierPrint()} | {votesReceived.PrettierPrint()} | {percentVotes.PrettierPrint()} |");
            WriteLine($"+ {string.Empty.PrettierPrint( replace : '-')} + {string.Empty.PrettierPrint(replace : '-')} + {string.Empty.PrettierPrint( replace :'-')} +");

            for (int i = 0; i < coallatedVotes.Length; i++) {
                Coallation coallatedVote = coallatedVotes[i];
                decimal percentageVote = Math.Round(percentageVotes(coallatedVote.GetVotes, totalVotesCast), 2);
                // WriteLine($"{coallatedVote.GetName}\t\t{coallatedVote.GetVotes}\t\t{percentageVote } %");
                WriteLine($"| {coallatedVote.GetName.PrettierPrint()} | {coallatedVote.GetVotes.ToString().PrettierPrint()} | {percentageVote.ToString().PrettierPrint()} |");
                WriteLine($"+ {string.Empty.PrettierPrint( replace : '-')} + {string.Empty.PrettierPrint(replace : '-')} + {string.Empty.PrettierPrint( replace :'-')} +");
            }

            WriteLine();
            WriteLine();
            WriteLine($"Total Vote cast: {totalVotesCast}");

            decimal percentageVotes(int candidateVotes, int totalVotes) {
                return ((decimal)candidateVotes / (decimal)totalVotes) * 100;
            }

        }

    }
}