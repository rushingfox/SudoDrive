using System.Collections.Generic;
using Server.Models.Entities;
using Server.Models.VO;

namespace Server.Models.DTO
{
    public class CommonUserProfileResultModel
    {
        public UserModel User { get; private set; }

        public List<GroupModel> Groups { get; private set; }

        public CommonUserProfileResultModel(User user)
        {
            this.User = user.ToVO();

            if (user.GroupToUser == null) return;

            Groups = new List<GroupModel>();
            foreach (var t in user.GroupToUser)
            {
                Groups.Add(t.Group.ToVO());
            }
        }

    }
}