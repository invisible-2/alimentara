using System;

namespace Alimentara
{
    class Admin
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Byte[] PassHash { get; set; }

    }
}
