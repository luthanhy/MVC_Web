using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HYTinatt.Models
{
    [MetadataType(typeof(Customers.MetaData))]
    public partial class Customers
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be empty CustomerID")]
            public int CustomerID { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be FirstName ")]
            public string FirstName { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be LastName ")]
            public string LastName { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be Email ")]
            public string Email { get; set; }
        }

    }
}