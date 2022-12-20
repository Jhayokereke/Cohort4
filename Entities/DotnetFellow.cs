namespace Entities
{
    public class DotnetFellow
    {
        public string Id { get; set; } //PrimaryKey
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int GenderId { get; set; } //ForeignKey to the Gender table
        public int StateId { get; set; } //ForeignKey to the States Table

        //Navigational properties
        public Gender Gender { get; set; }
        public State State { get; set; }
        public Address Address { get; set; }
        public ICollection<Phonenumber> Phonenumber { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; } //PrimaryKey
        public string GenderType { get; set; }
    }

    public class State
    {
        public int Id { get; set; } //PrimaryKey
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
    }

    public class Phonenumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
    }
}