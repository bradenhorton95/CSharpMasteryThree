using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ACS_BHortonM3
{
    internal class DBConnect
    {
        //connection string
        private const string CONNECT_STRING = @"Server=3.130.26.194;" +
                "Database=itse2353pbe;User Id=bhortonfa222353;" +
                "password=y3sJDVywD!";
        //build a connection to the books db
        private static SqlConnection _cntDatabase = new
            SqlConnection(CONNECT_STRING);

        //add the command object
        private static SqlCommand _sqlEmployeesCommand;

        //data adapter
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        //data tables
        private static DataTable _dtEmployeesTable = new DataTable();

        // publishers command object
        //add the command object
        private static SqlCommand _sqlSuppliersCommand;

        //data adapter
        private static SqlDataAdapter _daSuppliers = new SqlDataAdapter();
        //data tables
        private static DataTable _dtSuppliersTable = new DataTable();

        public static DataTable DTEmployeesTable
        {
            get { return _dtEmployeesTable; }
            set { _dtEmployeesTable = value; }
        }

        // get set for pub table
        public static DataTable DTSuppliersTable
        {
            get { return _dtSuppliersTable; }
            set { _dtSuppliersTable = value; }
        }


        public static void OpenDatabase()
        {
            //method to open db and to allow use of data
            //open the connection to book db
            _cntDatabase.Open();
            MessageBox.Show("Connection to database was successfully opened.");

        }


        public static void CloseDatabase()
        {
            //method to close data and dispose of all objects
            _cntDatabase.Close();
            //dispose
            _cntDatabase.Dispose();
            MessageBox.Show("Connection to database was successfully closed.");
            //dispos of all
            _sqlEmployeesCommand.Dispose();
            _daEmployees.Dispose();
            _dtEmployeesTable.Dispose();



        }

        public static void DisposeSup()
        {
            //dispos of all
            _sqlSuppliersCommand.Dispose();
            _daSuppliers.Dispose();
            _dtSuppliersTable.Dispose();



        }

        public static void DatabaseCommand(TextBox tbxEmpID, TextBox tbxFirstName, TextBox
           tbxLastName, TextBox tbxExtension)
        {


            try
            {
                string query = "SELECT * FROM bhortonfa222353.Employees ORDER BY FirstName";
                //est command obj
                _sqlEmployeesCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daEmployees = new SqlDataAdapter();
                _daEmployees.SelectCommand = _sqlEmployeesCommand;
                //fill data table
                _dtEmployeesTable = new DataTable();
                _daEmployees.Fill(_dtEmployeesTable);
                //bind controls to data table
                tbxEmpID.DataBindings.Add("Text", _dtEmployeesTable, "EmployeeID");
                tbxFirstName.DataBindings.Add("Text", _dtEmployeesTable, "FirstName");
                tbxLastName.DataBindings.Add("Text", _dtEmployeesTable, "LastName");
                tbxExtension.DataBindings.Add("Text", _dtEmployeesTable, "Extension");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Employees Table",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public static void DatabaseCommandSup(TextBox tbxSupplierID, TextBox tbxContactName, TextBox
           tbxCompanyName, TextBox tbxContactTitle, TextBox tbxPhone)
        {


            try
            {
                string query = "SELECT * FROM bhortonfa222353.Suppliers ORDER BY CompanyName";
                //est command obj
                _sqlSuppliersCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daSuppliers = new SqlDataAdapter();
                _daSuppliers.SelectCommand = _sqlSuppliersCommand;
                //fill data table
                _dtSuppliersTable = new DataTable();
                _daSuppliers.Fill(_dtSuppliersTable);
                //bind controls to data table
                tbxSupplierID.DataBindings.Add("Text", _dtSuppliersTable, "SupplierID");
                tbxContactName.DataBindings.Add("Text", _dtSuppliersTable, "ContactName");
                tbxCompanyName.DataBindings.Add("Text", _dtSuppliersTable, "CompanyName");
                tbxContactTitle.DataBindings.Add("Text", _dtSuppliersTable, "ContactTitle");
                tbxPhone.DataBindings.Add("Text", _dtSuppliersTable, "Phone");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Suppliers Table",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




    }
}
