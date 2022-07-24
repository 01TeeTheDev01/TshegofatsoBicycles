namespace User.Api.Models
{
    public class Employee : UserBlueprint
    {
        public string Id { get; set; }
        public override string FirstName { get; set; }
        public override string MiddleName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }
        public override string Gender { get; set; }
        public override string PhoneNumber { get; set; }
        public override string Email { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
    }
}
