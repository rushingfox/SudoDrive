using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Server.Models.VO;

namespace Server.Models.Entities
{
    public class User : ICreateTimeStampedModel, IUpdateTimeStampedModel
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<GroupToUser> GroupToUser { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Nickname { get; set; }

        public int? Status { get; set; } = 0;

        /// <summary>
        /// 判断这个用户是否有某个权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public bool? HasPermission(string[] permission)
        {
            var groupToUser = this.GroupToUser;
           
            bool? ret = null;

            foreach (var group in groupToUser)
            {
                var result = group.Group.HasPermission(permission);
                if (result == false) return false;
                if (result == true) ret = true;
            }

            return ret;
        }

        /// <summary>
        /// 判断这个用户是否有某个权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public bool? HasPermission(string permission)
        {
            return this.HasPermission(permission.Split('.'));
        }

        public UserModel ToVO()
            => new UserModel(this);
    }
}
