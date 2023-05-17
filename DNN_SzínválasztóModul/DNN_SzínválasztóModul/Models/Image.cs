using DotNetNuke.ComponentModel.DataAnnotations;
using System;

namespace Dnn.Artifox.DNN_SzínválasztóModul.Models
{

    [TableName("Image")]
    [PrimaryKey(nameof(ImageID), AutoIncrement = true)]
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