using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "DogsAllowed", "Location", "Name", "ParkMgmt" },
                values: new object[,]
                {
                    { 1, "Tucked away in the Rogue Valley has some natue and woods to explore. Features swimming, fishing, boating activies", true, "SW Oregon", "Valley of the Rogue River", "State Park" },
                    { 2, "Has lush rainforest and senic coastal vistas. Features hiking, historical sites,  kayaking, fishing, and wildlife", true, "NW Oregon", "Lewis and Clark National Historical Park", "National Park" },
                    { 3, "Rugged rocky terrain, colorful craggy badlands, features a museum, educational film on geology and fossils, hiking ", true, "East-Central Oregon ", "John Day Fossil Beds National Monument", "National Park" },
                    { 4, "Offers tours of cave complexes, Explore underground caverns. Features hunting, hiking, wildlife", true, "SW Oregon", "Oregon Caves National Monument and Preserve", "National Park" },
                    { 5, "Beautiful Scenery, boasting of the deepest river gorge in North America, features fishing, swimming, camping, and kayaking", true, "NE Oregon", "Hells Canyon National Recreation Area", "National Parks" },
                    { 6, "Home to spectacular lakes and lava flows.Formed after a violent volcanic eruption, Newberry Caldera is now home to the two arresting alpine lakes of Paulina Lake and East Lake. Features hiking and horse back riding.", true, "Central Oregon", "Newberry National Volcanic Monument ", "National Parks" },
                    { 7, "Most known for its craggy cliffs and climbing routes, Volcanic in origin, it showcases steep cliffs and sheer spires, with captivating climbing routes wherever you look. Features hiking, climbing, and camping.", true, "Central Oregon", "Smith Rock State Park", "State Park" },
                    { 8, "Home to beautiful beaches, forests, lakes, and islands. Reaching up to 150 meters in height, the dunes that dominate the park make up the largest expanse of coastal sands in the whole of North America. . These sprawling, windswept sandscapes make for a breathtaking sight and were actually the inspiration for Frank Herberts famed sci-fi novel Dune. Features horseback riding, dune-buggying, camping, fishing, and canoeing.", true, " ", "Oregon Dunes National Recreation Area", "W Oregon" },
                    { 9, "Blessed with an abundance of water falls Silver Falls is considered the crowned jewel of Oregons state park system. Features horesback riding, camping, and hiking. While dogs are mostly allowed, they are not allowed on the Cayon Trail.", false, "NW Oregon", "Silver Falls State Park", "State Park" },
                    { 10, "Dotted about its stunning shores, which stretch almost 15 kilometers in total, are sensational sea stacks, tidal pools, and beaches, with lush rainforest found inland. In the state park, visitors can go wildlife watching or stroll along the Oregon Coast Trail and bask in the phenomenal views out over the Pacific Ocean. Features hinking, and historic sites.", true, "NW Oregon", "Ecola State Park", "State Park" },
                    { 11, "The national scenic areas delightful and diverse landscapes lend themselves perfectly to all kinds of outdoor activities, with everything from hiking and mountain biking to rock climbing and rafting on offer.", true, "NW Oregon", "Columbia River Gorge National Senic Area", "National Parks" },
                    { 12, "Hemmed in on all sides by the crumbling cliffs of a long collapsed caldera, the brilliantly blue waters of Crater Lake make for a spectacular sight. The deepest lake in the US offers up fabulous photo opportunities to visitors from its rugged rim. Features fishing, scuba diving, and boat tours.", true, "S Oregon", "Crater Lake National Park", "National Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);
        }
    }
}
