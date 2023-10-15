namespace CarRentalWebService.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(int id, string name, string cpf, string login, string email, string password)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Login = login;
            Email = email;
            Password = password;
        }
    }
}
