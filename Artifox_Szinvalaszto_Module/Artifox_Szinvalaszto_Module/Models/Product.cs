using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.SzinvalasztoArtifox_Szinvalaszto_Module.Models
{
    [TableName("Artifox_Szinvalaszto_Module_Product")]
    [PrimaryKey(nameof(ProductId), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class Product
    {
        public int ProductId { get; set; }
        public int RGB_calculated { get; set; }
    }
}