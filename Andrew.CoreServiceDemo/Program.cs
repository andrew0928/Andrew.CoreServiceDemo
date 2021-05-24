using System;
using System.Collections.Generic;

namespace Andrew.CoreServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public class CoreEntityRepo<TEntity> where TEntity: EntityBasic
    {
        public TEntity GetEntityById(string id, int updateIndex = 0)
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntityById(string id, DateTime snapshotAt)
        {
            throw new NotImplementedException;
        }

        public IEnumerable<TEntity> GetEntities()
        {
            yield break;
        }
        public IEnumerable<TEntity> GetEntities(DateTime snapshotAt)
        {
            yield break;
        }



        public TEntity Create(TEntity data)
        {
            data.ID = null; // assign unique id
            data.UpdateIndex = 0;
            data.UpdateTime = DateTime.UtcNow;

            // do something else

            throw new NotImplementedException();
        }

        public TEntity Update(TEntity data)
        {
            TEntity origin = this.GetEntityById(data.ID, 0);  // load origin entity from ID

            if (origin.UpdateIndex != data.UpdateIndex) throw new InvalidOperationException();

            // do something else

            throw new NotImplementedException();
        }

        public TEntity Remove(TEntity data)
        {
            throw new NotImplementedException();
        }


    }

    public class EntityLink<TEntity> where TEntity : EntityBasic
    {
        public string ID;
        public int UpdateIndex;
    }


    public class UserEntity : EntityBasic { }
    public class AccountEntity: EntityBasic { }
    public class UserJourneyEntity : EntityBasic { }

    public class EntityBasic
    {
        public string ID { get; set; }

        public string TanentID { get; set; }

        public int UpdateIndex { get; set; }

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
