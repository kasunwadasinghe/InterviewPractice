using InterviewPractice.Data;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using InterviewPractice.Services;
using InterviewPractice.Dto;

namespace InterviewPractice
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataBinding();
            }
        }

        protected void grdEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
        }

        protected void DataBinding()
        {
            string query = "SELECT * FROM Employee_Tbl";
            var dt = DataService.GetData(query);
            grdEmployee.DataSource = dt;
            grdEmployee.DataBind();

            
        }

        protected void grdEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grdEmployee_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "cmdAdd")
                {
                    AddNewRecord();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void AddNewRecord()
        {
            var employeeObj = new EmployeeDto
            {
                First_Name = (grdEmployee.FooterRow.FindControl("txtFirstName") as TextBox).Text.Trim(),
                Last_Name = (grdEmployee.FooterRow.FindControl("txtLastName") as TextBox).Text.Trim(),
                Contact = (grdEmployee.FooterRow.FindControl("txtContact") as TextBox).Text.Trim(),
                Email = (grdEmployee.FooterRow.FindControl("txtEmail") as TextBox).Text.Trim()
            };
            EmployeeService emp = new EmployeeService();
            emp.InsertEmployee(employeeObj);
            DataBinding();
        }

        protected void grdEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdEmployee.EditIndex = e.NewEditIndex;
            DataBinding();
        }

        protected void grdEmployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdEmployee.EditIndex = -1;
            DataBinding();
        }

        protected void grdEmployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var employeeObj = new EmployeeDto
            {
                First_Name = (grdEmployee.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox).Text.Trim(),
                Last_Name = (grdEmployee.Rows[e.RowIndex].FindControl("txtLastName") as TextBox).Text.Trim(),
                Contact = (grdEmployee.Rows[e.RowIndex].FindControl("txtContact") as TextBox).Text.Trim(),
                Email = (grdEmployee.Rows[e.RowIndex].FindControl("txtEmail") as TextBox).Text.Trim(),
                Id = int.Parse(grdEmployee.DataKeys[e.RowIndex].Value.ToString())
            };
            EmployeeService emp = new EmployeeService();
            grdEmployee.EditIndex = -1;
            emp.UpdateEmployee(employeeObj);
            DataBinding();
        }

        protected void grdEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var employeeObj = new EmployeeDto
            {
                First_Name = (grdEmployee.FooterRow.FindControl("txtFirstName") as TextBox).Text.Trim(),
                Last_Name = (grdEmployee.FooterRow.FindControl("txtLastName") as TextBox).Text.Trim(),
                Contact = (grdEmployee.FooterRow.FindControl("txtContact") as TextBox).Text.Trim(),
                Email = (grdEmployee.FooterRow.FindControl("txtEmail") as TextBox).Text.Trim(),
                Id = int.Parse(grdEmployee.DataKeys[e.RowIndex].Value.ToString())
            };
            EmployeeService emp = new EmployeeService();
            emp.DeleteEmployee(employeeObj);
            DataBinding();
        }
    }
}