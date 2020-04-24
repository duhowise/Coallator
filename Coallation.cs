using System;

namespace Coallator
{
    internal class Coallation
    {

       
        private string lastName ;
        private int votes ;


        public void AddName(string name){
            lastName=name;
        } 
        public void AddVote(int vote){
            votes=vote;
        }

        public string GetName => lastName;
        public int GetVotes => votes;

        
    }
}