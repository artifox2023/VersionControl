using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.Artifox.Artifox_Szinvalaszto_Modul.Models
{
    [TableName("Product")]
    [PrimaryKey(nameof(ProductId), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class Product
    {
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int RGB_calcvalue { get; set; }
    }
}