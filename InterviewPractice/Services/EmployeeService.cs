using InterviewPractice.Data;
using InterviewPractice.Dto;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InterviewPractice.Services
{
    public class EmployeeService
    {
        public async Task InsertEmployee(EmployeeDto employee)
        {
            string query = "INSERT INTO Employee_Tbl (First_Name,Last_Name,Contact_No,Email_Address) VALUES (@First_Name,@Last_Name,@Contact_No,@Email_Address)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@First_Name", employee.First_Name);
            cmd.Parameters.AddWithValue("@Last_Name", employee.Last_Name);
            cmd.Parameters.AddWithValue("@Contact_No", employee.Contact);
            cmd.Parameters.AddWithValue("@Email_Address", employee.Email);

            DataService.InsertRecord(cmd);

        }

        public async Task UpdateEmployee(EmployeeDto employee)
        {
            string query = "UPDATE Employee_Tbl SET First_Name=@First_Name,Last_Name=@Last_Name,Contact_No=@Contact_No,Email_Address=@Email_Address WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Id", employee.Id);
            cmd.Parameters.AddWithValue("@First_Name", employee.First_Name);
            cmd.Parameters.AddWithValue("@Last_Name", employee.Last_Name);
            cmd.Parameters.AddWithValue("@Contact_No", employee.Contact);
            cmd.Parameters.AddWithValue("@Email_Address", employee.Email);

            DataService.UpdateRecord(cmd);

        }

        public async Task DeleteEmployee(EmployeeDto employee)
        {
            string query = "DELETE Employee_Tbl WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Id", employee.Id);

            DataService.DeleteRecord(cmd);

        }
    }
}