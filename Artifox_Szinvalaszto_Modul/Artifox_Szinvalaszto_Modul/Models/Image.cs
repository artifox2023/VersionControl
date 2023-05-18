using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.Artifox.Artifox_Szinvalaszto_Modul.Models
{
    [TableName("Image")]
    [PrimaryKey(nameof(ImageId), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string UserId { get; set; }
        public int ModuleId { get; set; }
    }
}