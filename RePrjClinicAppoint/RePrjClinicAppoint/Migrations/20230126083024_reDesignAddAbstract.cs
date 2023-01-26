using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RePrjClinicAppoint.Migrations
{
    public partial class reDesignAddAbstract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Appointment_AppointmentServerId",
                table: "Details");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patient",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AppointmentServerId",
                table: "Details",
                newName: "AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Details_AppointmentServerId",
                table: "Details",
                newName: "IX_Details_AppointmentId");

            migrationBuilder.RenameColumn(
                name: "ServerId",
                table: "Appointment",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "creater",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "Patient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRemoved",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedDate",
                table: "Patient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modifier",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "creater",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "Doctor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRemoved",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedDate",
                table: "Doctor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modifier",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "creater",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "Details",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRemoved",
                table: "Details",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedDate",
                table: "Details",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modifier",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "creater",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "Appointment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRemoved",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedDate",
                table: "Appointment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modifier",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoginLoggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accessUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loginIp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    creater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginLoggers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Appointment_AppointmentId",
                table: "Details",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Appointment_AppointmentId",
                table: "Details");

            migrationBuilder.DropTable(
                name: "LoginLoggers");

            migrationBuilder.DropColumn(
                name: "creater",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "isRemoved",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "modifiedDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "modifier",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "creater",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "isRemoved",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "modifiedDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "modifier",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "creater",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "isRemoved",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "modifiedDate",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "modifier",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "creater",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "isRemoved",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "modifiedDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "modifier",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patient",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctor",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Details",
                newName: "AppointmentServerId");

            migrationBuilder.RenameIndex(
                name: "IX_Details_AppointmentId",
                table: "Details",
                newName: "IX_Details_AppointmentServerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Appointment",
                newName: "ServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Appointment_AppointmentServerId",
                table: "Details",
                column: "AppointmentServerId",
                principalTable: "Appointment",
                principalColumn: "ServerId");
        }
    }
}
