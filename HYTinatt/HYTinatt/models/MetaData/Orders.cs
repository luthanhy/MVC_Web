using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HYTinatt.Models.MetaData
{
    [MetadataType(typeof(Orders.MetaData))]
    public partial class Orders
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty OrderID")]
            public int OrderID { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty TotalAmount")]
            [Range(1,double.MaxValue, ErrorMessage = "TotalAmount is must greater than 0")]
            public decimal TotalAmount { get; set; }
        }
    }
}