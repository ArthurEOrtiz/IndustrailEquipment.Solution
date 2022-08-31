using Microsoft.EntityFrameworkCore.Migrations;

namespace IndustrailEquipment.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "MachineId", "Hours", "Name", "SerialNumber", "Status" },
                values: new object[,]
                {
                    { 1, 302, "AGV_01", "2867654", "Running" },
                    { 2, 246, "AGV_02", "2658392", "Faulted" },
                    { 3, 432, "AGV_03", "9867232", "Idle" },
                    { 4, 654, "AGV_04", "2837892", "Running" },
                    { 5, 123, "AGV_05", "2839404", "Running" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "MachineId",
                keyValue: 5);
        }
    }
}
