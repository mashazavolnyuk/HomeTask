using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class BD
    {
        private string name;
        private List <Commit> mycommit;

        public BD(string Name){
            this.name=Name;
        }

     public List<Commit> getAllCommit(){
         return mycommit;
     }
     
    }
}
