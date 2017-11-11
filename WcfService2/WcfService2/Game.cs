using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ClassLibrary1
{


    [DataContract]
    public class Game
    {
        [DataMember]
        private string title;
        [DataMember]
        private string kind;
        [DataMember]
        private int year;

        public string SetGame(string title, string kind, int year)
        {
            title = this.title;
            kind = this.kind;
            year = this.year;
            return string.Format("Title: {0}, Kind: {1}, Year: {2}", title, kind, year);
        }
    }
    public class Producer
    {
        public string name;
        public string founder;
        public int foundingyear;

        public Producer(string name, string founder, int foundingyear)
        {
            name = this.name;
            founder = this.founder;
            foundingyear = this.foundingyear;
        }

    }
    public class Platform
    {
        public string name;
        public int year;

        public Platform(string name, int year)
        {
            name = this.name;
            year = this.year;

        }
    }
}