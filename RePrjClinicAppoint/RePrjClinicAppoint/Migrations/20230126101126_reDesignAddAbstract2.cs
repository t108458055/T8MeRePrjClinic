using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RePrjClinicAppoint.Migrations
{
    public partial class reDesignAddAbstract2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Appointment_AppointmentId",
                table: "Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginLoggers",
                table: "LoginLoggers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IsMailConfirm",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "dental",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "dental",
                table: "Details");

            migrationBuilder.RenameTable(
                name: "LoginLoggers",
                newName: "LoginLogger");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "Detail");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Patient",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Patient",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patient",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Patient",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Patient",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Account",
                table: "Patient",
                newName: "account");

            migrationBuilder.RenameColumn(
                name: "IsPhoneConfirm",
                table: "Patient",
                newName: "IsConfirm");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Doctor",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Doctor",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctor",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Doctor",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Doctor",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Account",
                table: "Doctor",
                newName: "account");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Appointment",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Appointment",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Appointment",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CancelDate",
                table: "Appointment",
                newName: "cancelDate");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Appointment",
                newName: "isFinish");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Detail",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Detail",
                newName: "description");

            migrationBuilder.RenameIndex(
                name: "IX_Details_AppointmentId",
                table: "Detail",
                newName: "IX_Detail_AppointmentId");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "account",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirm",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "appointService",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "serviceStatus",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Detail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "isFinishStatus",
                table: "Detail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginLogger",
                table: "LoginLogger",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detail",
                table: "Detail",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Appointment_AppointmentId",
                table: "Detail",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Appointment_AppointmentId",
                table: "Detail");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginLogger",
                table: "LoginLogger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detail",
                table: "Detail");

            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "appointService",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "serviceStatus",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "isFinishStatus",
                table: "Detail");

            migrationBuilder.RenameTable(
                name: "LoginLogger",
                newName: "LoginLoggers");

            migrationBuilder.RenameTable(
                name: "Detail",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Patient",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Patient",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Patient",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Patient",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Patient",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "account",
                table: "Patient",
                newName: "Account");

            migrationBuilder.RenameColumn(
                name: "IsConfirm",
                table: "Patient",
                newName: "IsPhoneConfirm");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Doctor",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Doctor",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Doctor",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Doctor",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Doctor",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "account",
                table: "Doctor",
                newName: "Account");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Appointment",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Appointment",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Appointment",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "cancelDate",
                table: "Appointment",
                newName: "CancelDate");

            migrationBuilder.RenameColumn(
                name: "isFinish",
                table: "Appointment",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Details",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Details",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_AppointmentId",
                table: "Details",
                newName: "IX_Details_AppointmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsMailConfirm",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Patient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Doctor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "dental",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Details",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Details",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "dental",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginLoggers",
                table: "LoginLoggers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Appointment_AppointmentId",
                table: "Details",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }
    }
}
