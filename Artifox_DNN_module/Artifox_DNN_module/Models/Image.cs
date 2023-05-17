using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace Dnn.Artifox.Artifox_DNN_module.Models
{
    [TableName("Image")]
    [PrimaryKey(nameof(ImageId), AutoIncrement = true)]
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }

        [IgnoreColumn]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}