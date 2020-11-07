using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models.VO
{
    public class FileListRequestModel
    {
        public string Folder { get; set; }

        public string PathPrefix { get; set; }

        /// <summary>
        /// 与关系
        /// </summary>
        public string[] PathContains { get; set; }

        /// <summary>
        /// 与关系
        /// </summary>
        public string[] NameContains { get; set; }

        /// <summary>
        /// 或关系
        /// </summary>
        public string[] Type { get; set; }

        [Range(1, 1000)]
        public int Amount { get; set; } = 100;

        [Range(0, Int32.MaxValue)]
        public int Offset { get; set; } = 0;
    }
}