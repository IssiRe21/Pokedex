using System;
using System.Collections.Generic;

namespace Pokemon
{
    public class Pokemon
    {
        protected string name{ get; set; }
        protected int id;

        public Pokemon(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string Getname()
        {
            return name;
        }
        public int Getid()
        {
            return id;
        }

    }
}