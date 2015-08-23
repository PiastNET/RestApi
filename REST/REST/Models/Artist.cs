using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Models
{
  public class Artist
  {
    public int ID  { get; set; }
    public string Name { get; set; }
    public string ActivityYears { get; set; }

    public Artist()
    {
      this.Songs = new HashSet<Song>();
    }

    public virtual ICollection<Song> Songs { get; set; } 
  }
}