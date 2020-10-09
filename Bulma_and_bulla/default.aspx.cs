using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_and_bulla
{
    public partial class _default : System.Web.UI.Page
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BulmaAndBulla.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnHomeClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Home_Panel.Enabled = true;

            About_Panel.Visible = false;
            About_Panel.Enabled = false;

            Contact_Panel.Visible = false;
            Contact_Panel.Enabled = false;

            Menu_Panel.Visible = false;
            Menu_Panel.Enabled = false;

            SignIn_Panel.Visible = false;
            SignIn_Panel.Enabled = false;

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;
        }

        protected void OnAboutClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Home_Panel.Enabled = false;

            About_Panel.Visible = true;
            About_Panel.Enabled = true;

            Contact_Panel.Visible = false;
            Contact_Panel.Enabled = false;

            Menu_Panel.Visible = false;
            Menu_Panel.Enabled = false;

            SignIn_Panel.Visible = false;
            SignIn_Panel.Enabled = false;

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;
        }

        protected void OnContactClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Home_Panel.Enabled = false;

            About_Panel.Visible = false;
            About_Panel.Enabled = false;

            Contact_Panel.Visible = true;
            Contact_Panel.Enabled = true;

            Menu_Panel.Visible = false;
            Menu_Panel.Enabled = false;

            SignIn_Panel.Visible = false;
            SignIn_Panel.Enabled = false;

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;
        }

        protected void OnMenuClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Home_Panel.Enabled = false;

            About_Panel.Visible = false;
            About_Panel.Enabled = false;

            Contact_Panel.Visible = false;
            Contact_Panel.Enabled = false;

            Menu_Panel.Visible = true;
            Menu_Panel.Enabled = true;

            SignIn_Panel.Visible = false;
            SignIn_Panel.Enabled = false;

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;
        }

        protected void OnCustClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Home_Panel.Enabled = false;

            About_Panel.Visible = false;
            About_Panel.Enabled = false;

            Contact_Panel.Visible = false;
            Contact_Panel.Enabled = false;

            Menu_Panel.Visible = false;
            Menu_Panel.Enabled = false;

            SignIn_Panel.Visible = true;
            SignIn_Panel.Enabled = true;

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;
        }

        protected void OnSignUpLinkClick(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Home_Panel.Enabled = false;

            About_Panel.Visible = false;
            About_Panel.Enabled = false;

            Contact_Panel.Visible = false;
            Contact_Panel.Enabled = false;

            Menu_Panel.Visible = false;
            Menu_Panel.Enabled = false;

            SignIn_Panel.Visible = false;
            SignIn_Panel.Enabled = false;

            SignUp_Panel.Visible = true;
            SignUp_Panel.Enabled = true;
        }

        protected void OnOrderClick(object sender, EventArgs e)
        {
            Page_Load(sender, e);
        }

        protected void OnSignInClick(object sender, EventArgs e)
        {

            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();

                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = $"SELECT * FROM dbo.Customer WHERE Customer.Cust_Email_Address = {Email_Txt.Text}";
                if(cmd.ExecuteNonQuery() == 0)
                {
                    signInUnable.Text = "Unable to Sign In. Verify Your credentials or Create an Account";
                }
                else
                {
                    AuthenticatedSpace.Visible = true;
                    AuthenticatedSpace.Enabled = true;
                }

                cmd.Dispose();
                restaurantConnection.Close();
            }
            catch (SystemException)
            {

            }
           
        }

        public void OnSignUpClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();

                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO dbo.Customer VALUES (@Cust_Last_Name, @Cust_First_Name, @Cust_Phone_Number, @Cust_Address_Line, @Cust_Email_Address, @Cust_Address_City, @Cust_Gender, @Password)";
                cmd.Parameters.AddWithValue("Cust_Last_Name", lastNameTxt.Text);
                cmd.Parameters.AddWithValue("Cust_First_Name", firstNameTxt.Text);
                cmd.Parameters.AddWithValue("Cust_Phone_Number", phoneTxt.Text);
                cmd.Parameters.AddWithValue("Cust_Address_Line", addressTxt.Text);
                cmd.Parameters.AddWithValue("Cust_Email_Address", emailTxt.Text);
                cmd.Parameters.AddWithValue("Cust_Address_City", cityTxt.Text);
                cmd.Parameters.AddWithValue("Cust_Gender", genderDrop.Text);
                cmd.Parameters.AddWithValue("Password", passwordTxt.Text);

                cmd.ExecuteNonQuery();
                restaurantConnection.Close();

                SignedUpAlert.Text = "Congratulations on your new account. Check your email for more Information!";
            }
            catch (Exception ex)
            {
                SignedUpAlert.Text = ex.Message;
            }
        }
    }
}