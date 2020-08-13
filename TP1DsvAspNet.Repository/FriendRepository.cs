using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TP1DsvAspNet.Domain;
using TP1DsvAspNet.Repository.Context;

namespace TP1DsvAspNet.Repository
{
    public class FriendRepository
    {
        private FriendContext Context { get; set; }

        public FriendRepository(FriendContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Friend> GetAll()
        {
            return Context.Friends.AsEnumerable();
        }

        public Friend GetFriendById(Guid id)
        {
            return Context.Friends.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Friend friend) 
        {
            this.Context.Friends.Add(friend);
            this.Context.SaveChanges();
        }

        public void Delete(Guid id) 
        {
            this.Context.Friends.Remove(Context.Friends.FirstOrDefault(x => x.Id == id));
            this.Context.SaveChanges();
        }

        public void Update(Guid id, Friend friend) 
        {
            var old = Context.Friends.FirstOrDefault(x => x.Id == id);

            old.Name = friend.Name;
            old.Surname = friend.Surname;
            old.Email = friend.Email;
            old.Birthday = friend.Birthday;

            Context.Friends.Update(old);
            this.Context.SaveChanges();
        }
    }
}
