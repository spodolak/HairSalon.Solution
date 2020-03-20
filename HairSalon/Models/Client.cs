using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public int CuisineId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}