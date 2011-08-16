using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BellWether.Models {
  public class Bell {

      public int Id { get; set; }
      public int UserId { get; set; }
    [Required()]
    public string Name { get; set; }

      public virtual User User { get; set; }



  }
}