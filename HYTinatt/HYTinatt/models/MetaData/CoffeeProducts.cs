using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HYTinatt.Models
{
    [MetadataType(typeof(CoffeeProducts.MetaData))]
    public  partial class CoffeeProducts
    {

        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty ProductID")]
            public int ProductID { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty Name")]
            public string Name { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty Price")]
            [Range(0, double.MaxValue, ErrorMessage = "Price is greater than 0")]
            public decimal Price { get; set; }

        }
    }
}