using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace BellWether.Models {
    [DataServiceKey("BellId")]
  public class Bell {

      public int BellId { get; set; }
      public int UserId { get; set; }
    [Required()]
    public string Name { get; set; }

      public virtual User User { get; set; }



  }
}