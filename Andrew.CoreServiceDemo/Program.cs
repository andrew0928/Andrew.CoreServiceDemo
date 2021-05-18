using System;

namespace Andrew.CoreServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class UserEntity : EntityBasic { }
    public class AccountEntity: EntityBasic { }
    public class UserJourneyEntity : EntityBasic { }

    public class EntityBasic
    {
        public string ID { get; set; }

        public string TanentID { get; set; }

        public int Version { get; set; }

        public DateTime UpdateTime { get; set; }

        // json payload
        public string Payload { get; set; }
    }


    public class TenantSettings
    {
        // 展開可對應到 shop id, supplier id 等等。這邊 demo 不額外註記
        public string TanentID { get; set; }    
        
        public string DataSource { get; set; }

        // private key
        public string EncryptKey { get; set; }

        public int UpdateIndex { get; set; }
    }
}
