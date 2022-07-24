namespace User.Api.Models
{
    public abstract class UserBlueprint
    {
        public abstract string FirstName { get; set; }
        public abstract string MiddleName { get; set; }
        public abstract string LastName { get; set; }
        public abstract int Age { get; set; }
        public abstract string Gender { get; set; }
        public abstract string PhoneNumber { get; set; }
        public abstract string Email { get; set; }
    }
}
