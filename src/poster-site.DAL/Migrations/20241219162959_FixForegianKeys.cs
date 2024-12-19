using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace poster_site.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixForegianKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicSubscriptionsUser");

            migrationBuilder.DropTable(
                name: "TopicTopicSubscriptions");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Posters",
                newName: "BaseMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TokenId",
                table: "Users",
                column: "TokenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TopicSubscriptions_TopicId",
                table: "TopicSubscriptions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicSubscriptions_UserId",
                table: "TopicSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_BaseMediaId",
                table: "Posters",
                column: "BaseMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_News_MediaId",
                table: "News",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_News_TopicId",
                table: "News",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseMedias_AlbumId",
                table: "BaseMedias",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseMedias_GameId",
                table: "BaseMedias",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseMedias_BaseMedias_AlbumId",
                table: "BaseMedias",
                column: "AlbumId",
                principalTable: "BaseMedias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseMedias_BaseMedias_GameId",
                table: "BaseMedias",
                column: "GameId",
                principalTable: "BaseMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_BaseMedias_MediaId",
                table: "News",
                column: "MediaId",
                principalTable: "BaseMedias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Topics_TopicId",
                table: "News",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posters_BaseMedias_BaseMediaId",
                table: "Posters",
                column: "BaseMediaId",
                principalTable: "BaseMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicSubscriptions_Topics_TopicId",
                table: "TopicSubscriptions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicSubscriptions_Users_UserId",
                table: "TopicSubscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tokens_TokenId",
                table: "Users",
                column: "TokenId",
                principalTable: "Tokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseMedias_BaseMedias_AlbumId",
                table: "BaseMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseMedias_BaseMedias_GameId",
                table: "BaseMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_News_BaseMedias_MediaId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Topics_TopicId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Posters_BaseMedias_BaseMediaId",
                table: "Posters");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicSubscriptions_Topics_TopicId",
                table: "TopicSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicSubscriptions_Users_UserId",
                table: "TopicSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tokens_TokenId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TokenId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TopicSubscriptions_TopicId",
                table: "TopicSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_TopicSubscriptions_UserId",
                table: "TopicSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Posters_BaseMediaId",
                table: "Posters");

            migrationBuilder.DropIndex(
                name: "IX_News_MediaId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_TopicId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_BaseMedias_AlbumId",
                table: "BaseMedias");

            migrationBuilder.DropIndex(
                name: "IX_BaseMedias_GameId",
                table: "BaseMedias");

            migrationBuilder.RenameColumn(
                name: "BaseMediaId",
                table: "Posters",
                newName: "MediaId");

            migrationBuilder.CreateTable(
                name: "TopicSubscriptionsUser",
                columns: table => new
                {
                    TopicSubscriptionsId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicSubscriptionsUser", x => new { x.TopicSubscriptionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TopicSubscriptionsUser_TopicSubscriptions_TopicSubscription~",
                        column: x => x.TopicSubscriptionsId,
                        principalTable: "TopicSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicSubscriptionsUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicTopicSubscriptions",
                columns: table => new
                {
                    TopicSubscriptionsId = table.Column<int>(type: "integer", nullable: false),
                    TopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTopicSubscriptions", x => new { x.TopicSubscriptionsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_TopicTopicSubscriptions_TopicSubscriptions_TopicSubscriptio~",
                        column: x => x.TopicSubscriptionsId,
                        principalTable: "TopicSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicTopicSubscriptions_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicSubscriptionsUser_UsersId",
                table: "TopicSubscriptionsUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicTopicSubscriptions_TopicsId",
                table: "TopicTopicSubscriptions",
                column: "TopicsId");
        }
    }
}
