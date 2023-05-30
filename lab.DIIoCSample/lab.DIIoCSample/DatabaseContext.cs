using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.DIIoCSample
{
    public class DatabaseContext
    {
        //private MSSql _db;
        //private Oracle _db;
        private readonly IConnect _db;

        public DatabaseContext(IConnect db)
        {
            _db = db;
        }

        public void ConnectDatabase()
        {
            _db.Connect();
        }
    }

    public interface IConnect
    {
        public void Connect();
    }

    public class MSSql : IConnect
    {
        public void Connect()
        {
            Console.WriteLine("Connect to MS SQL");
        }
    }

    public class Oracle : IConnect
    {
        public void Connect()
        {
            Console.WriteLine("Connect to Oracle");
        }
    }
}
