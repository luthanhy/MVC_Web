using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HYTinatt.Models
{
    [MetadataType(typeof(OrderDetails.MetaData))]
    public partial class OrderDetails
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty OrderDetailID")]
            public int OrderDetailID { get; set; }
        }
    }
}