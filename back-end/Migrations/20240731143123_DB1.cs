using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class DB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gadget",
                columns: table => new
                {
                    GadgetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GadgetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gadget", x => x.GadgetId);
                });

            migrationBuilder.CreateTable(
                name: "GameMode",
                columns: table => new
                {
                    GameModeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameModeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMode", x => x.GameModeId);
                });

            migrationBuilder.CreateTable(
                name: "Side",
                columns: table => new
                {
                    SideId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SideName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Side", x => x.SideId);
                });

            migrationBuilder.CreateTable(
                name: "Squad",
                columns: table => new
                {
                    SquadId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SquadName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squad", x => x.SquadId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponType",
                columns: table => new
                {
                    WeaponTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponType", x => x.WeaponTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    OperatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OperatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Difficult = table.Column<int>(type: "int", nullable: false),
                    BiographyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquadId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.OperatorId);
                    table.ForeignKey(
                        name: "FK_Operator_Side_SideId",
                        column: x => x.SideId,
                        principalTable: "Side",
                        principalColumn: "SideId");
                    table.ForeignKey(
                        name: "FK_Operator_Squad_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squad",
                        principalColumn: "SquadId");
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    WeaponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeaponTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuantityOfAmmo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.WeaponId);
                    table.ForeignKey(
                        name: "FK_Weapon_WeaponType_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "WeaponType",
                        principalColumn: "WeaponTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    AbilityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.AbilityId);
                    table.ForeignKey(
                        name: "FK_Ability_Operator_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operator",
                        principalColumn: "OperatorId");
                });

            migrationBuilder.CreateTable(
                name: "Biography",
                columns: table => new
                {
                    BiographyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PshychologicalReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biography", x => x.BiographyId);
                    table.ForeignKey(
                        name: "FK_Biography_Operator_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operator",
                        principalColumn: "OperatorId");
                });

            migrationBuilder.CreateTable(
                name: "OperatorGadget",
                columns: table => new
                {
                    OperatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GadgetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuantityOfGadget = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorGadget", x => new { x.GadgetId, x.OperatorId });
                    table.ForeignKey(
                        name: "FK_OperatorGadget_Gadget_GadgetId",
                        column: x => x.GadgetId,
                        principalTable: "Gadget",
                        principalColumn: "GadgetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperatorGadget_Operator_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operator",
                        principalColumn: "OperatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperatorWeapon",
                columns: table => new
                {
                    OperatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorWeapon", x => new { x.OperatorId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_OperatorWeapon_Operator_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operator",
                        principalColumn: "OperatorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperatorWeapon_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_OperatorId",
                table: "Ability",
                column: "OperatorId",
                unique: true,
                filter: "[OperatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Biography_OperatorId",
                table: "Biography",
                column: "OperatorId",
                unique: true,
                filter: "[OperatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Operator_SideId",
                table: "Operator",
                column: "SideId");

            migrationBuilder.CreateIndex(
                name: "IX_Operator_SquadId",
                table: "Operator",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatorGadget_OperatorId",
                table: "OperatorGadget",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatorWeapon_WeaponId",
                table: "OperatorWeapon",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_WeaponTypeId",
                table: "Weapon",
                column: "WeaponTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Biography");

            migrationBuilder.DropTable(
                name: "GameMode");

            migrationBuilder.DropTable(
                name: "OperatorGadget");

            migrationBuilder.DropTable(
                name: "OperatorWeapon");

            migrationBuilder.DropTable(
                name: "Gadget");

            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Side");

            migrationBuilder.DropTable(
                name: "Squad");

            migrationBuilder.DropTable(
                name: "WeaponType");
        }
    }
}
