using Deadline6SecondTry.Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Deadline6SecondTry;

namespace Deadline6SecondTry.Repositories
{
    public abstract class Repository<T> where T : Entity
    {   
        private string Path { get; set; }
        
        public List<T> Entities { get; set; }

        public Repository(string _Path)
        {
            Path = _Path;
            Entities = FileWorker.GetObjects<T>(Path);
            
        }
        public T GetById(int Id)
        {
            return Entities.FirstOrDefault(i => i.Id == Id);
        }

        public List<T> GetAll()
        {
            return Entities;
        }

        public void Create(T entity)
        {
            entity.Id = Entities.Count + 1;
            Entities.Add(entity);
            FileWorker.SaveObjects<T>(Entities, Path);
        }

        public void Update(T entity)
        {
            var UpdateEntity = Entities.FirstOrDefault(i => i.Id == entity.Id);
            Entities.Remove(UpdateEntity);
            Entities.Add(entity);
            FileWorker.SaveObjects<T>(Entities, Path);
        }
    }
}
