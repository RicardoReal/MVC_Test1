using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Test1
{
    

    [MetadataType(typeof(RoleMetadata))]
    public partial class Role
    {

    }

    public class RoleMetadata
    {
        [Display(Name = "xpto")]
        public string Role1 { get; set; }

        public string Description { get; set; }

    }
}