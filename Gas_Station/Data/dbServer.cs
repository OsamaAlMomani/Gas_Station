using Microsoft.EntityFrameworkCore;

namespace Gas_Station.Data
{
    public class dbServer:DbContext
    {
        public dbServer(DbContextOptions<dbServer> options ):base(options) { }
        
        

    }
}
