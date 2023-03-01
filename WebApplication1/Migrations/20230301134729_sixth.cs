using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Cars_CarId",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Cars_CarId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Users_UserId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Auctions_AuctionId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Cars_CarId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressId1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "AuctionBid");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Payments_AuctionId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CarId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_UserId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Bids_CarId",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Bids_UserId",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_CarId",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId1",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AuctionBid",
                columns: table => new
                {
                    AuctionsAuctionId = table.Column<int>(type: "int", nullable: false),
                    BidsBidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionBid", x => new { x.AuctionsAuctionId, x.BidsBidId });
                    table.ForeignKey(
                        name: "FK_AuctionBid_Auctions_AuctionsAuctionId",
                        column: x => x.AuctionsAuctionId,
                        principalTable: "Auctions",
                        principalColumn: "AuctionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionBid_Bids_BidsBidId",
                        column: x => x.BidsBidId,
                        principalTable: "Bids",
                        principalColumn: "BidId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId1",
                table: "Users",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AuctionId",
                table: "Payments",
                column: "AuctionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CarId",
                table: "Payments",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_CarId",
                table: "Bids",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_UserId",
                table: "Bids",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_CarId",
                table: "Auctions",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionBid_BidsBidId",
                table: "AuctionBid",
                column: "BidsBidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Cars_CarId",
                table: "Auctions",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Cars_CarId",
                table: "Bids",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Users_UserId",
                table: "Bids",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Auctions_AuctionId",
                table: "Payments",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "AuctionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Cars_CarId",
                table: "Payments",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_AddressId1",
                table: "Users",
                column: "AddressId1",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
