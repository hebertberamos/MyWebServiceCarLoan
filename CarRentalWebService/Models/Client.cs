using CarRentalWebService.Models.Enums;

namespace CarRentalWebService.Models
{
    public class Client : User
    {
        public ClientLevel? Level { get; set; }
        public bool AlreadyInLoan { get; set; } = false;

        public Client()
        {
        }
        public Client(int id, string name, string cpf, string login, string email, string password, ClientLevel level) : base(id, name, cpf, login, email, password)
        {
            Level = level;
        }
    }
}
