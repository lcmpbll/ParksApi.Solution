namespace ParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public bool DogsAllowed { get; set; }
    public string ParkMgmt { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
  }
}