using System;

namespace Coallator
{
    class Program
    {


        static void Main(string[] args)
        {
            Coallation[] coallatedVotes;

            // enter polling station id
            var pollingStationId="";
            // number of candidates that contested the election
            var totalNumberOfCandidates=0;

            // name of electoral commisssioner
            var electoralCommisioner="";

            var totalVotesCast=0;

            // last names of each of the candidates and the number of votes received
            System.Console.WriteLine("Enter the name of the electoral commissioner");
            electoralCommisioner=System.Console.ReadLine();

            //request the polling Station Id
            System.Console.WriteLine("Enter the polling Station Id");
           
            // capture the polling Station Id
            pollingStationId=System.Console.ReadLine();

            //request the total number of candidates
            System.Console.WriteLine("Enter the total number of candidates");
           
            // capture the total number of candidates
            totalNumberOfCandidates=Convert.ToInt32(System.Console.ReadLine());

            // set array size for the coallated votes
            coallatedVotes=new Coallation[totalNumberOfCandidates];

            // Keep requesting and saving the candidate's last name and total votes until the last one
            for (int numberProcessed = 0; numberProcessed < totalNumberOfCandidates; numberProcessed++)
            {
                // initialise array for the number of total votes
                var collation=new Coallation();

                System.Console.WriteLine("Enter the last name of a candidate");
                collation.AddName(System.Console.ReadLine());
                System.Console.WriteLine($"Enter votes for '{collation.GetName}'");
                collation.AddVote(Convert.ToInt32(System.Console.ReadLine()));
                

                coallatedVotes[numberProcessed]=collation;
                // add this candidates vote to the total votes
                totalVotesCast+=collation.GetVotes;
            }





            System.Console.WriteLine($"Polling Station Id: {pollingStationId}");
            System.Console.WriteLine($"Electoral Commissioner: {electoralCommisioner}");
            System.Console.WriteLine();
            System.Console.WriteLine("Candidate\tVotes Received\tPercentage of total votes");

            for (int i = 0; i < coallatedVotes.Length; i++)
            {
                Coallation coallatedVote = coallatedVotes[i];
                decimal percentageVote=Math.Round(percentageVotes(coallatedVote.GetVotes,totalVotesCast),2);
                System.Console.WriteLine($"{coallatedVote.GetName}\t\t{coallatedVote.GetVotes}\t\t{percentageVote } %");
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"Total Vote cast: {totalVotesCast}");

         
         decimal percentageVotes(int candidateVotes, int totalVotes)
        {
            return ((decimal)candidateVotes / (decimal)totalVotes) * 100;
        }


        }

        
    }
}
