using System;

namespace Alimentara
{
    class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Pass { get; set; }
        public Byte[] PassHash { get; set; }

    }
}
