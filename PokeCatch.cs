using System;
using System.Collections.Generic;

namespace Pokemon
{
    public enum Gender
    {
        Male,
        Female
    }
    public class PokeCatch : Pokemon
    {
        Gender gender;

        public PokeCatch(string name, int id, Gender gender) : base(name,id)
        {
            this.gender = gender;
        }
    }

}