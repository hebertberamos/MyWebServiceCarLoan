namespace CarRentalWebService.Models
{
    public class Admin : User
    {
        public int ProtocolNumber { get; set; }

        public Admin()
        {
        }
        public Admin(int id, string name, string cpf, string login, string email, string password, int protocolNumber) : base(id, name, cpf, login, email, password)
        {
            ProtocolNumber = protocolNumber;
        }
    }
}
