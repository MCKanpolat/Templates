namespace GraphQLTemplate.Models
{
    using System;

    public class Droid : Character
    {
        public DateTime Created { get; set; }

        public string PrimaryFunction { get; set; }
    }
}
