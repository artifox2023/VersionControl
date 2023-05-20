using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.SzinvalasztoArtifox_Szinvalaszto_Module.Models
{
    [TableName("Artifox_Szinvalaszto_Module_Image")]
    [PrimaryKey(nameof(ImageId), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
    }
}