using System.Collections.Generic;

namespace soscialMedia
{
    public class Profile
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        private List<Profile> Friends { get; set; }

        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }
        public void RemoveFriend(Profile friendToRemove)
        {
            Friends.Remove(friendToRemove);
        }
    }
}