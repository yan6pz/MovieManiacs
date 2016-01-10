namespace Core.InfoModels
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public System.Guid Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
