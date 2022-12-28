using System.Collections.Generic;
using MySqlConnector;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public List<Client> Clients { get; set; }
  }
}