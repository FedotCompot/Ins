﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbIns.Migrations
{
    /// <inheritdoc />
    public partial class newFieldInAgrement12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agreements_Apartments_IdApartment",
                table: "Agreements");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdApartment",
                table: "Agreements",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agreements_Apartments_IdApartment",
                table: "Agreements",
                column: "IdApartment",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agreements_Apartments_IdApartment",
                table: "Agreements");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdApartment",
                table: "Agreements",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Agreements_Apartments_IdApartment",
                table: "Agreements",
                column: "IdApartment",
                principalTable: "Apartments",
                principalColumn: "Id");
        }
    }
}
