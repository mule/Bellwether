using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BellWether.Models {
  public class Bell {
    [Required()]
    public string Name { get; set; }
  }
}