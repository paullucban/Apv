using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Apv.AV.Services.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModelClasses",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    companyId = table.Column<string>(nullable: true),
                    countryCode = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    modelClassBrand = table.Column<string>(nullable: true),
                    modelClassCode = table.Column<string>(nullable: true),
                    modelClassId = table.Column<string>(nullable: true),
                    modelClassLabel = table.Column<string>(nullable: true),
                    modelClassLabelLoc = table.Column<string>(nullable: true),
                    modelClassTypeLabel = table.Column<string>(nullable: true),
                    modelClassTypeLabelLoc = table.Column<string>(nullable: true),
                    order = table.Column<decimal>(nullable: false),
                    published = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelClasses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    companyId = table.Column<string>(maxLength: 10, nullable: false),
                    companyCode = table.Column<string>(maxLength: 10, nullable: true),
                    companyLogo = table.Column<string>(maxLength: 500, nullable: true),
                    companyName = table.Column<string>(maxLength: 500, nullable: true),
                    companyNameLoc = table.Column<string>(maxLength: 500, nullable: true),
                    createdBy = table.Column<string>(maxLength: 30, nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(maxLength: 500, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    homePage = table.Column<string>(maxLength: 1000, nullable: true),
                    lastUpdatedBy = table.Column<string>(maxLength: 30, nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    latitude = table.Column<string>(maxLength: 10, nullable: true),
                    longtitude = table.Column<string>(maxLength: 10, nullable: true),
                    mobile = table.Column<string>(maxLength: 20, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    postalCode = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.companyId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    countryCode = table.Column<string>(maxLength: 3, nullable: false),
                    countryName = table.Column<string>(maxLength: 3, nullable: true),
                    createdBy = table.Column<string>(maxLength: 30, nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    currencySymbol = table.Column<string>(maxLength: 3, nullable: true),
                    dateFormat = table.Column<string>(maxLength: 20, nullable: true),
                    formatDisplayDecimalPlace = table.Column<int>(nullable: false),
                    lastUpdatedBy = table.Column<string>(maxLength: 30, nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    roundingMethodForCalculation = table.Column<string>(maxLength: 20, nullable: true),
                    timeZone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.countryCode);
                });

            migrationBuilder.CreateTable(
                name: "FinancialProducts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialProducts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    downloadUrl = table.Column<string>(nullable: true),
                    features = table.Column<string>(nullable: true),
                    forceUpgrade = table.Column<bool>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    newVersionCode = table.Column<decimal>(nullable: false),
                    platform = table.Column<string>(nullable: true),
                    prevVersionCode = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CarModelClassImage",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarModelClassid = table.Column<string>(nullable: true),
                    coverImage = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    onlineImage = table.Column<string>(nullable: true),
                    thumbnailImage = table.Column<string>(nullable: true),
                    verticalImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelClassImage", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarModelClassImage_CarModelClasses_CarModelClassid",
                        column: x => x.CarModelClassid,
                        principalTable: "CarModelClasses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    carModelClassid = table.Column<string>(nullable: true),
                    carModelId = table.Column<string>(nullable: true),
                    coverImage = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    modelLabel = table.Column<string>(nullable: true),
                    modelLabelLoc = table.Column<string>(nullable: true),
                    order = table.Column<decimal>(nullable: false),
                    published = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarModelClasses_carModelClassid",
                        column: x => x.carModelClassid,
                        principalTable: "CarModelClasses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryGlobalSettings",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 36, nullable: false),
                    companyId = table.Column<string>(nullable: true),
                    countryCode = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(maxLength: 30, nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(maxLength: 30, nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    maintenanceMessage = table.Column<string>(nullable: true),
                    maintenanceMode = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryGlobalSettings", x => x.id);
                    table.ForeignKey(
                        name: "FK_CountryGlobalSettings_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "companyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountryGlobalSettings_Countries_countryCode",
                        column: x => x.countryCode,
                        principalTable: "Countries",
                        principalColumn: "countryCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarModelFinancialProduct",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarModelid = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    financialProductid = table.Column<int>(nullable: true),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelFinancialProduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarModelFinancialProduct_CarModels_CarModelid",
                        column: x => x.CarModelid,
                        principalTable: "CarModels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarModelFinancialProduct_FinancialProducts_financialProductid",
                        column: x => x.financialProductid,
                        principalTable: "FinancialProducts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarPrice",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarModelid = table.Column<string>(nullable: true),
                    companyId = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPrice", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarPrice_CarModels_CarModelid",
                        column: x => x.CarModelid,
                        principalTable: "CarModels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModelClassImage_CarModelClassid",
                table: "CarModelClassImage",
                column: "CarModelClassid");

            migrationBuilder.CreateIndex(
                name: "IX_CarModelFinancialProduct_CarModelid",
                table: "CarModelFinancialProduct",
                column: "CarModelid");

            migrationBuilder.CreateIndex(
                name: "IX_CarModelFinancialProduct_financialProductid",
                table: "CarModelFinancialProduct",
                column: "financialProductid");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_carModelClassid",
                table: "CarModels",
                column: "carModelClassid");

            migrationBuilder.CreateIndex(
                name: "IX_CarPrice_CarModelid",
                table: "CarPrice",
                column: "CarModelid");

            migrationBuilder.CreateIndex(
                name: "IX_CountryGlobalSettings_companyId",
                table: "CountryGlobalSettings",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryGlobalSettings_countryCode",
                table: "CountryGlobalSettings",
                column: "countryCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModelClassImage");

            migrationBuilder.DropTable(
                name: "CarModelFinancialProduct");

            migrationBuilder.DropTable(
                name: "CarPrice");

            migrationBuilder.DropTable(
                name: "CountryGlobalSettings");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "FinancialProducts");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CarModelClasses");
        }
    }
}
