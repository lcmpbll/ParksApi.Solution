using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public ParksApiContext(DbContextOptions<ParksApiContext> options)
      : base(options)
      { 
      }
      
    public DbSet<Park> Parks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Valley of the Rogue River", DogsAllowed = true, ParkMgmt = "State Park", Location = "SW Oregon", Description = "Tucked away in the Rogue Valley has some natue and woods to explore. Features swimming, fishing, boating activies" },
        new Park { ParkId = 2, Name = "Lewis and Clark National Historical Park", DogsAllowed = true, ParkMgmt = "National Park", Location = "NW Oregon", Description = "Has lush rainforest and senic coastal vistas. Features hiking, historical sites,  kayaking, fishing, and wildlife" },
        new Park { ParkId = 3, Name = "John Day Fossil Beds National Monument", DogsAllowed = true, ParkMgmt = "National Park", Location = "East-Central Oregon ", Description = "Rugged rocky terrain, colorful craggy badlands, features a museum, educational film on geology and fossils, hiking " },
        new Park { ParkId = 4, Name = "Oregon Caves National Monument and Preserve", DogsAllowed = true, ParkMgmt = "National Park", Location = "SW Oregon", Description = "Offers tours of cave complexes, Explore underground caverns. Features hunting, hiking, wildlife" },
        new Park { ParkId = 5, Name = "Hells Canyon National Recreation Area", DogsAllowed = true, ParkMgmt = "National Parks", Location = "NE Oregon", Description = "Beautiful Scenery, boasting of the deepest river gorge in North America, features fishing, swimming, camping, and kayaking" },
        new Park { ParkId = 6, Name = "Newberry National Volcanic Monument ", DogsAllowed = true, ParkMgmt = "National Parks", Location = "Central Oregon", Description = "Home to spectacular lakes and lava flows.Formed after a violent volcanic eruption, Newberry Caldera is now home to the two arresting alpine lakes of Paulina Lake and East Lake. Features hiking and horse back riding." },
        new Park { ParkId = 7, Name = "Smith Rock State Park", DogsAllowed = true, ParkMgmt = "State Park", Location = "Central Oregon", Description = "Most known for its craggy cliffs and climbing routes, Volcanic in origin, it showcases steep cliffs and sheer spires, with captivating climbing routes wherever you look. Features hiking, climbing, and camping." },
        new Park { ParkId = 8, Name = "Oregon Dunes National Recreation Area", DogsAllowed = true, ParkMgmt = "W Oregon", Location = " ", Description = "Home to beautiful beaches, forests, lakes, and islands. Reaching up to 150 meters in height, the dunes that dominate the park make up the largest expanse of coastal sands in the whole of North America. . These sprawling, windswept sandscapes make for a breathtaking sight and were actually the inspiration for Frank Herberts famed sci-fi novel Dune. Features horseback riding, dune-buggying, camping, fishing, and canoeing." },
        new Park { ParkId = 9, Name = "Silver Falls State Park", DogsAllowed = false, ParkMgmt = "State Park", Location = "NW Oregon", Description = "Blessed with an abundance of water falls Silver Falls is considered the crowned jewel of Oregons state park system. Features horesback riding, camping, and hiking. While dogs are mostly allowed, they are not allowed on the Cayon Trail." },
        new Park { ParkId = 10, Name = "Ecola State Park", DogsAllowed = true, ParkMgmt = "State Park", Location = "NW Oregon", Description = "Dotted about its stunning shores, which stretch almost 15 kilometers in total, are sensational sea stacks, tidal pools, and beaches, with lush rainforest found inland. In the state park, visitors can go wildlife watching or stroll along the Oregon Coast Trail and bask in the phenomenal views out over the Pacific Ocean. Features hinking, and historic sites." },
        new Park { ParkId = 11, Name = "Columbia River Gorge National Senic Area", DogsAllowed = true, ParkMgmt = "National Parks", Location = "NW Oregon", Description = "The national scenic areas delightful and diverse landscapes lend themselves perfectly to all kinds of outdoor activities, with everything from hiking and mountain biking to rock climbing and rafting on offer." },
        new Park { ParkId = 12, Name = "Crater Lake National Park", DogsAllowed = true, ParkMgmt = "National Park", Location = "S Oregon", Description = "Hemmed in on all sides by the crumbling cliffs of a long collapsed caldera, the brilliantly blue waters of Crater Lake make for a spectacular sight. The deepest lake in the US offers up fabulous photo opportunities to visitors from its rugged rim. Features fishing, scuba diving, and boat tours." }
      ); 
    }
  }
}


