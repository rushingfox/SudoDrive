using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.TencentCos
{
    /// <summary>
    /// 任务队列的文件控制块
    /// </summary>
    public class FCB
    {
        /// <summary>
        /// 内部处理Key
        /// </summary>
        public long Key { get; set; }

        /// <summary>
        /// 操作类型 1：上传，2：下载，3：删除
        /// </summary>
        public OperationType Operation { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件本地路径（不含文件名）
        /// </summary>
        public string LocalPath { get; set; }

        /// <summary>
        /// 文件远端路径（不含文件名）
        /// </summary>
        public string RemotePath { get; set; }

        /// <summary>
        /// 文件MD5
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// 已上传文件大小
        /// </summary>
        public long Completed { get; set; }

        /// <summary>
        /// 总文件大小
        /// </summary>
        public long Total { get; set; }

        /// <summary>
        /// 任务状态 0：未开始，1：进行中，2：请求暂停，3：已暂停，4：请求开始，5：请求停止
        /// </summary>
        public StatusType Status { get; set; }


    }

}