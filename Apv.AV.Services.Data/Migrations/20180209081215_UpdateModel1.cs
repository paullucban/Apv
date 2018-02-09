using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Apv.AV.Services.Data.Migrations
{
    public partial class UpdateModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelFinancialProduct_CarModels_CarModelid",
                table: "CarModelFinancialProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModelFinancialProduct_FinancialProducts_financialProductid",
                table: "CarModelFinancialProduct");

            migrationBuilder.RenameColumn(
                name: "financialProductid",
                table: "CarModelFinancialProduct",
                newName: "FinancialProductid");

            migrationBuilder.RenameColumn(
                name: "CarModelid",
                table: "CarModelFinancialProduct",
                newName: "carModelid");

            migrationBuilder.RenameIndex(
                name: "IX_CarModelFinancialProduct_financialProductid",
                table: "CarModelFinancialProduct",
                newName: "IX_CarModelFinancialProduct_FinancialProductid");

            migrationBuilder.RenameIndex(
                name: "IX_CarModelFinancialProduct_CarModelid",
                table: "CarModelFinancialProduct",
                newName: "IX_CarModelFinancialProduct_carModelid");

            migrationBuilder.AddColumn<string>(
                name: "companyId",
                table: "FinancialProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countryCode",
                table: "FinancialProducts",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelFinancialProduct_FinancialProducts_FinancialProductid",
                table: "CarModelFinancialProduct",
                column: "FinancialProductid",
                principalTable: "FinancialProducts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelFinancialProduct_CarModels_carModelid",
                table: "CarModelFinancialProduct",
                column: "carModelid",
                principalTable: "CarModels",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelFinancialProduct_FinancialProducts_FinancialProductid",
                table: "CarModelFinancialProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModelFinancialProduct_CarModels_carModelid",
                table: "CarModelFinancialProduct");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "FinancialProducts");

            migrationBuilder.DropColumn(
                name: "countryCode",
                table: "FinancialProducts");

            migrationBuilder.RenameColumn(
                name: "carModelid",
                table: "CarModelFinancialProduct",
                newName: "CarModelid");

            migrationBuilder.RenameColumn(
                name: "FinancialProductid",
                table: "CarModelFinancialProduct",
                newName: "financialProductid");

            migrationBuilder.RenameIndex(
                name: "IX_CarModelFinancialProduct_carModelid",
                table: "CarModelFinancialProduct",
                newName: "IX_CarModelFinancialProduct_CarModelid");

            migrationBuilder.RenameIndex(
                name: "IX_CarModelFinancialProduct_FinancialProductid",
                table: "CarModelFinancialProduct",
                newName: "IX_CarModelFinancialProduct_financialProductid");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelFinancialProduct_CarModels_CarModelid",
                table: "CarModelFinancialProduct",
                column: "CarModelid",
                principalTable: "CarModels",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelFinancialProduct_FinancialProducts_financialProductid",
                table: "CarModelFinancialProduct",
                column: "financialProductid",
                principalTable: "FinancialProducts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
