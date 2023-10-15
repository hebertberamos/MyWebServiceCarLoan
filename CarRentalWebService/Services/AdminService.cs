using CarRentalWebService.Data;
using CarRentalWebService.Models;

namespace CarRentalWebService.Services
{
    public class AdminService
    {
        private readonly ConnectionContext _context;

        public AdminService(ConnectionContext context)
        {
            _context = context;
        }

        public List<Admin> FindAllAdmins()
        {
            return _context.Admin.ToList();
        }
    }
}
