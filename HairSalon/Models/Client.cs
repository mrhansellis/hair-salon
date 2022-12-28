using MySqlConnector;

namespace HairSalon.Models
{
  public class Client
  {
    public string ClientName { get; set; }
    public int ClientId { get; set; }
    public string HairType { get; set; }
    public int SylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}