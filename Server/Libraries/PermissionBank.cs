namespace Server.Libraries
{
    public class PermissionBank
    {
        public const string UserAuthRegister = "user.auth.register";
        public const string UserAuthLogin = "user.auth.login";
        public const string UserAuthRefresh = "user.auth.refresh";
        public const string UserAuthUpdatePassword = "user.auth.updatepassword";

        public const string StorageFileUploadBasic = "storage.file.upload.basic";
        public const string StorageFileDeleteBase = "storage.file.delete.basic";
        public const string StorageFileListBasic = "storage.file.list.basic";

        public const string GroupManageGroupAdd = "groupmanager.group.add.basic";
        public const string GroupManageGroupDelete = "groupmanager.group.delete.basic";
        public const string GroupManageGroupQuit = "groupmanager.group.quit.basic";
        public const string GroupManageGroupMemberAdd = "groupmanager.group.member.add.basic";
        public const string GroupManageGroupMemberDelete = "groupmanager.group.member.delete.basic";

        /// <summary>
        /// 生成文件访问权限
        /// </summary>
        /// <param name="type">权限类型：users / groups / root</param>
        /// <param name="name">权限类型对应的用户/组名：username / groupname</param>
        /// <param name="operation">操作：upload / delete / list</param>
        /// <returns></returns>
        public static string StoragePermission(string type, string name, string operation)
        {
            if (type == "root") return $"storage.file.operation.root.{operation}";
            return $"storage.file.operation.{type}.{name}.{operation}";
        }

        /// <summary>
        /// 生成组访问权限
        /// </summary>
        /// <param name="groupName">组名</param>
        /// <param name="type">生成类型：member</param>
        /// <param name="operation">操作：add / delete</param>
        /// <returns></returns>
        public static string GroupOperationPermission(string groupName, string type, string operation)
        {
            return $"groupmanager.group.operation.{groupName}.{type}.{operation}";
        }
    }
}
