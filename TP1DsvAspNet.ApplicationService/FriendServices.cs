using System;
using System.Collections.Generic;
using System.Text;
using TP1DsvAspNet.Domain;
using TP1DsvAspNet.Repository;

namespace TP1DsvAspNet.ApplicationService
{
    public class FriendServices
    {
        private FriendRepository Repository { get; set; }

        public FriendServices(FriendRepository repository) 
        {
            this.Repository = repository;
        }

        public IEnumerable<Friend> GetAll() 
        {
            return Repository.GetAll();
        }

        public Friend GetFriendById(Guid id) 
        {
            return Repository.GetFriendById(id);
        }

        public void Save(Friend friend) 
        {
            Repository.Save(friend);
        }

        public void Delete(Guid id) 
        {
            Repository.Delete(id);
        }

        public void Update(Guid id, Friend friend) 
        {
            Repository.Update(id, friend);
        }
    }
}
