using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using System.Data.Common;

namespace Bulma_and_bulla
{
    public partial class _default : System.Web.UI.Page
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vikto\Desktop\Bulma_and_bulla\Bulma_and_bulla\App_Data\BulmaAndBulla.mdf;Integrated Security=True";
        string signedInEmail;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string controlID = "";
                if (!String.IsNullOrEmpty(Request.Form["__EVENTTARGET"]))
                {
                    controlID = Page.Request.Params["__EVENTTARGET"];
                    //Control postbackControl = Page.FindControl(ControlID);
                    string menuItemsString = "menuItem";
                    string orderButtonString = "orderButton";
                    int menuItemsResult = String.Compare(controlID, 0, menuItemsString, 0, menuItemsString.Length - 1);
                    int orderButtonResult = String.Compare(controlID, 0, orderButtonString, 0, orderButtonString.Length - 1);
                    if(menuItemsResult == 0)
                    {
                        OpenMenuDetails(controlID);
                    }
                    else if(orderButtonResult == 0)
                    {
                        //Add to order method
                    }
                }
            }
            
        }


        protected void PanelEnable(Panel enablePanel)
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;

            try
            {
                using(SqlConnection restaurantConnection = new SqlConnection(connectionString))
                {
                    restaurantConnection.Open();
                    SqlCommand cmd = restaurantConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Location_ID, City, Street_Line, Postal_Code, Phone From dbo.Locations";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        switch (reader[0])
                        {
                            case 1000:
                                MontrealStreet.Text = reader.GetString(2);
                                MontrealCode.Text = reader.GetString(3);
                                MontrealPhone.Text = reader.GetString(4);
                                break;
                            case 1010:
                                MontrealStreet1.Text = reader.GetString(2);
                                MontrealCode1.Text = reader.GetString(3);
                                MontrealPhone1.Text = reader.GetString(4); 
                                break;
                            case 1020:
                                LaSalleStreet.Text = reader.GetString(2);
                                LaSalleCode.Text = reader.GetString(3);
                                LaSallePhone.Text = reader.GetString(4);
                                break;
                            case 1040:
                                LavalStreet.Text = reader.GetString(2);
                                LavalCode.Text = reader.GetString(3);
                                LavalPhone.Text = reader.GetString(4); 
                                break;
                            case 1050:
                                LongueilStreet.Text = reader.GetString(2);
                                LongueilCode.Text = reader.GetString(3);
                                LongueilPhone.Text = reader.GetString(4);
                                break;
                        }
                    }

                    reader.Close();
                    restaurantConnection.Close();
                }
            }
            catch (SystemException)
            {

            }
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;

            try
            {
                using (SqlConnection restaurantConnection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT Product_Image, Product_Name, Product_Price, Product_Origin, Product_Id FROM dbo.Menu", restaurantConnection);
                    restaurantConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Table table = new Table();
                    Menu_Control_Panel.Controls.Add(table);

                    while (reader.Read())
                    {
                        //Create table dynamically
                        int items = 6;

                        TableRow tr = new TableRow();
                        for (int i = 0; i < items; i++)
                        {
                            TableCell tc = new TableCell();
                            tc.Width = 180;
                            if (i == 0)
                            {
                                System.Web.UI.WebControls.Image image = new System.Web.UI.WebControls.Image();
                                image.Height = 100;
                                image.Width = 180;
                                image.ImageUrl = (string)reader.GetString(i);
                                tc.Controls.Add(image);
                                tr.Cells.Add(tc);
                            }
                            else if (i == 2)
                            {
                                Label label = new Label();
                                label.Text = "$" + reader.GetValue(i).ToString();
                                tc.Controls.Add(label);
                                tr.Cells.Add(tc);

                            }
                            else if (i < 4)
                            {
                                Label label = new Label();
                                label.Text = reader.GetValue(i).ToString();
                                tc.Controls.Add(label);
                                tr.Cells.Add(tc);

                            }
                            else if (i == 4)
                            {
                                LinkButton link = new LinkButton();
                                link.ID = "menuItem" + reader.GetValue(i).ToString();
                                link.Text = "Details";
                                tc.Controls.Add(link);
                                tr.Cells.Add(tc);

                            }
                            else if (i == 5)
                            {
                                Button orderButton = new Button();
                                orderButton.ID = "orderButton" + reader.GetValue(4).ToString();
                                orderButton.Text = "Add to Order";
                                tc.Controls.Add(orderButton);
                                tr.Cells.Add(tc);

                            }

                        }
                        table.Controls.Add(tr);
                    }
                    reader.Close();
                    restaurantConnection.Close();
                }
            }
            catch (SystemException)
            {

            }
        }

        protected void OpenMenuDetails(string controlID)
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

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;

            Details_Panel.Visible = true;
            Details_Panel.Enabled = true;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;

            string controlId = controlID;
            string productId = controlId.Substring(8);

            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();
                SqlCommand command = restaurantConnection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT Product_Name, Product_Description, Product_Price, Nutritional_Value, Product_Type, Product_Origin, Product_Image FROM dbo.Menu WHERE Product_ID = {productId}";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds);

                Table table = new Table();
                table.CellSpacing = 10;

                //Row 1
                TableRow tr1 = new TableRow();

                //Image in cell 1, row 1
                TableCell tc11 = new TableCell();
                System.Web.UI.WebControls.Image image = new System.Web.UI.WebControls.Image();
                image.Height = 130;
                image.Width = 200;
                image.ImageUrl = ds.Tables[0].Rows[0]["Product_Image"].ToString();
                tc11.Controls.Add(image);
                tr1.Controls.Add(tc11);

                //Origin, type, description in cell 2, row 1
                TableCell tc12 = new TableCell();
                Label tc2Label = new Label();
                tc2Label.Text = ds.Tables[0].Rows[0]["Product_Origin"].ToString() + "</br> </br>" + ds.Tables[0].Rows[0]["Product_Type"].ToString() + "</br> </br>" + ds.Tables[0].Rows[0]["Product_Description"].ToString();
                tc12.Controls.Add(tc2Label);
                tr1.Cells.Add(tc12);

                //Nutritional value in cell 3, row 1
                TableCell tc13 = new TableCell();
                Label tc13Label = new Label();
                tc13Label.Text = ds.Tables[0].Rows[0]["Nutritional_Value"].ToString();
                tc13.Controls.Add(tc13Label);
                tr1.Cells.Add(tc13);
                table.Rows.Add(tr1);

                //Row 2
                TableRow tr2 = new TableRow();
                tr2.HorizontalAlign = HorizontalAlign.Center;

                //Name in cell 1
                TableCell tc21 = new TableCell();
                Label tc21Label = new Label();
                tc21Label.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
                tc21.Controls.Add(tc21Label);
                tr2.Cells.Add(tc21);

                //Price in cell 2
                TableCell tc22 = new TableCell();
                Label tc22Label = new Label();
                tc22Label.Text = "$" + ds.Tables[0].Rows[0]["Product_Price"].ToString();
                tc22.Controls.Add(tc22Label);
                tr2.Cells.Add(tc22);

                //Order button in cell 3
                TableCell tc23 = new TableCell();
                Button orderButton = new Button();
                orderButton.ID = "orderButton" + controlId;
                orderButton.Text = "Add to order";
                tc23.Controls.Add(orderButton);
                tr2.Cells.Add(tc23);

                table.Rows.Add(tr2);

                Table_Panel.Controls.Add(table);

                restaurantConnection.Close();
            }
            catch (SystemException)
            {

            }
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;
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

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;
        }

        protected void OnOrderClick(object sender, EventArgs e)
        {
            //Page_Load(sender, e);
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

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Order_Panel.Visible = true;
            Order_Panel.Enabled = true;
            
            // <3 
       /*         using (SqlConnection restaurantConnection = new SqlConnection(connectionString))
                {
                    restaurantConnection.Open();
                    SqlCommand cmd = restaurantConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //Write the query
                    cmd.CommandText = "";
                    SqlDataReader dr = cmd.ExecuteReader();
                    orderGridview.DataSource = dr;
                    orderGridview.DataBind();
                    restaurantConnection.Close();
                }
                orderGridview.Visible = true;

            if (signedInEmail != "") 
            { 
                //create the order for the signed in customer using the signedInEmail
            }
            else
            {
                Label l = new Label();
                l.Text = "You are not signed in, you will not be able to view this order later";
                Order_Panel.Controls.Add(l);
            }*/
        }

        protected void OnSignInClick(object sender, EventArgs e)
        {
            string emailToCheck = Email_Txt.Text;
            string passwordToCheck = Password_Txt.Text;
            try
            { 
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();

                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
            
                cmd.CommandText = $"SELECT * FROM dbo.Customer WHERE Cust_Email_Address = '{emailToCheck}'";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows[0]["Password"].ToString() == passwordToCheck)
                {
                    signInUnable.Text = "Signed in";
                    signedInEmail = ds.Tables[0].Rows[0]["Cust_Email_Address"].ToString();
                    OpenProfilePanel(Int32.Parse(ds.Tables[0].Rows[0]["Customer_ID"].ToString()));
                }
                else
                {
                    signInUnable.Text = "Password incorrect.";
                }
                restaurantConnection.Close();
            }
            catch (Exception ex)
            {
                string error1 = "There is no row at position 0.";
                if(ex.Message == error1)
                {
                    signInUnable.Text = "There is no account under this email address.";
                }
                else
                {
                    signInUnable.Text = ex.Message;
                }
                
            }
           
        }

        public void OnSignUpClick(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string phoneNumber = phoneTxt.Text;
            string address = addressTxt.Text;
            string email = emailTxt.Text;
            string city = cityTxt.Text;
            string gender = genderDrop.SelectedItem.Text;
            string password = passwordTxt.Text;
            
            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();

                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO dbo.Customer VALUES (@Cust_Last_Name, @Cust_First_Name, @Cust_Phone_Number, @Cust_Address_Line, @Cust_Email_Address, @Cust_Address_City, @Cust_Gender, @Password)";
                cmd.Parameters.AddWithValue("Cust_Last_Name", lastName);
                cmd.Parameters.AddWithValue("Cust_First_Name", firstName);
                cmd.Parameters.AddWithValue("Cust_Phone_Number", phoneNumber);
                cmd.Parameters.AddWithValue("Cust_Address_Line", address);
                cmd.Parameters.AddWithValue("Cust_Email_Address", email);
                cmd.Parameters.AddWithValue("Cust_Address_City", city);
                cmd.Parameters.AddWithValue("Cust_Gender", gender);
                cmd.Parameters.AddWithValue("Password", password);

                cmd.ExecuteNonQuery();
                restaurantConnection.Close();
                signedInEmail = email;

                SignedUpAlert.Text = "Congratulations on your new account. Check your email for more Information!";
            }
            catch (Exception ex)
            {
                SignedUpAlert.Text = ex.Message;
            }

            SendEmail(lastName, firstName, phoneNumber, address, email, city, gender, password);
        }

        protected void SendEmail(string l, string f, string pN, string a, string e, string c, string g, string p)
        {
        /*    string sender = "Bulma.Bulla.Co@gmail.com";
            string receiver = e;
            string subject = "Account Created!";
            string mailBody = $"Thank you for creating a customer account at Bulma & Bulla! <br/>Here are your account credentials: " +
                $"<br/>Last Name: {l} <br/>First Name: {f} <br/>Phone Number: {pN} <br/>Address: {a} <br/>Email Address: {e} <br/>City: {c} <br/>Gender: {g}";
            MailMessage message = new MailMessage(sender, receiver, subject, mailBody);
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("Bulma.Bulla.Co@gmail.com", "Bull@2020");
            client.Send(message);
        */
        }

        protected void OpenProfilePanel(int customerID)
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

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            MatchFindPanel.Visible = false;
            MatchFindPanel.Enabled = false;

            Profile_Panel.Visible = true;
            Profile_Panel.Enabled = true;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;

            pSaveButton.Enabled = false;
            pFirstNameTxtbox.Enabled = false;
            pLastNameTxtbox.Enabled = false;
            pPasswordTxtBox.Enabled = false;
            pPhoneTxtbox.Enabled = false;
            pCityTxtbox.Enabled = false;
            pAddressTxtbox.Enabled = false;
            pGenderDropDown.Enabled = false;
            pGenderDropDown.Visible = false;

            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();
                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM dbo.Customer WHERE Customer_ID = {customerID}";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);

                pFirstNameTxtbox.Text = ds.Tables[0].Rows[0]["Cust_First_Name"].ToString();
                pLastNameTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Last_Name"].ToString();
                pPhoneTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Phone_Number"].ToString();
                pEmailTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Email_Address"].ToString();
                pCityTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Address_City"].ToString();
                pAddressTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Address_Line"].ToString();
                pPasswordTxtBox.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                pGenderTxtbox.Text = ds.Tables[0].Rows[0]["Cust_Gender"].ToString();

                restaurantConnection.Close();
            }catch(SystemException)
            {

            }
            
        }

        protected void OnEditClick(object sender, EventArgs e)
        {
            pSaveButton.Enabled = true;
            pFirstNameTxtbox.Enabled = true;
            pLastNameTxtbox.Enabled = true;
            pPasswordTxtBox.Enabled = true;
            pPhoneTxtbox.Enabled = true;
            pCityTxtbox.Enabled = true;
            pAddressTxtbox.Enabled = true;
            pGenderDropDown.Enabled = true;
            pGenderDropDown.Visible = true;
        }

        protected void onSaveClick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();
                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE dbo.Customer SET Cust_Last_Name = '{pLastNameTxtbox.Text}', Cust_First_Name = '{pFirstNameTxtbox.Text}'," +
                    $" Cust_Phone_Number = '{pPhoneTxtbox.Text}', Cust_Address_Line = '{pAddressTxtbox.Text}', " +
                    $"Cust_Address_City = '{pCityTxtbox.Text}', Cust_Gender = '{pGenderDropDown.SelectedItem.Text}', " +
                    $"Password = '{pPasswordTxtBox.Text}' WHERE Cust_Email_Address = '{pEmailTxtbox.Text}'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"SELECT Customer_ID FROM dbo.Customer WHERE Cust_Email_Address = '{pEmailTxtbox.Text}'";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                int customerID = Int32.Parse(ds.Tables[0].Rows[0]["Customer_ID"].ToString());
                restaurantConnection.Close();
                OpenProfilePanel(customerID);
            }
            catch (SystemException)
            {

            }
            
        }

        protected void OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                string emailToCheck = pEmailTxtbox.Text;

                SqlConnection restaurantConnection = new SqlConnection(connectionString);
                restaurantConnection.Open();
                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT Customer_ID FROM dbo.Customer WHERE Cust_Email_Address = '{emailToCheck}'";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                int customerID = Int32.Parse(ds.Tables[0].Rows[0]["Customer_ID"].ToString());

                cmd.CommandText = $"DELETE FROM dbo.Comments WHERE Customer_ID = {customerID}";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"DELETE FROM dbo.Order_Item WHERE EXISTS (" +
                $"SELECT Order_Items_ID FROM [Order] WHERE Customer_ID = {customerID})";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"DELETE FROM dbo.Customer WHERE Customer_ID = {customerID}";
                cmd.ExecuteNonQuery();

                restaurantConnection.Close();

                OnCustClick(sender, e);
            }
            catch (SystemException)
            {

            }
            
        }

        protected void DownloadDeals_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = @"~\Newsletter\DEALSNEWSLETTER.pdf";

                HttpResponse res = HttpContext.Current.Response;
                res.Clear();
                res.AppendHeader("content-disposition", "attachment; filename=newsletter.pdf");
                res.ContentType = "application/octet-stream";
                res.WriteFile(filename);
                res.Flush();
                res.End();
            }
            catch (SystemException)
            {

            }

        }

        protected void SubmitComment_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection restaurantConnection = new SqlConnection(connectionString))
                {
                    restaurantConnection.Open();
                    SqlCommand cmd = restaurantConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    string customerEmail = commentEmailtext.Text;
                    cmd.CommandText = $"SELECT Customer_ID FROM dbo.Customer WHERE Cust_Email_Address = '{customerEmail}'";
                    int customerID = (int) cmd.ExecuteScalar();

                    cmd.CommandText = "INSERT INTO dbo.Comments VALUES (@Customer_ID, @Comment)";
                    cmd.Parameters.AddWithValue("Customer_ID", customerID);
                    cmd.Parameters.AddWithValue("Comment", commentText.Text);
                    
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    restaurantConnection.Close();

                }

                SubmittedComment.Text = "We have Received your comments and suggestions. Thanks you!";
            }
            catch (SystemException)
            {
                SubmittedComment.ForeColor = Color.Red;
                SubmittedComment.Text = "Sorry, somthing went wrong with your comment. We will work on that!";
            }
            finally
            {
                commentEmailtext.Text = "";
                commentText.Text = "";
            }
        }

        protected void Match_Button_Click(object sender, EventArgs e)
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

            SignUp_Panel.Visible = false;
            SignUp_Panel.Enabled = false;

            Details_Panel.Visible = false;
            Details_Panel.Enabled = false;

            Profile_Panel.Visible = false;
            Profile_Panel.Enabled = false;

            MatchFindPanel.Visible = true;
            MatchFindPanel.Enabled = true;

            Order_Panel.Visible = false;
            Order_Panel.Enabled = false;


        }

        protected void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection restaurantConnection = new SqlConnection(connectionString))
                {
                    restaurantConnection.Open();
                    SqlCommand cmd = restaurantConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    String matchEmail = MatchTxt.Text;
                    cmd.CommandText = "SELECT Cust_Last_Name, Cust_First_Name, Cust_Phone_Number, Cust_Address_City, Cust_Gender " +
                        "FROM dbo.Customer JOIN dbo.Order ON customer.customer_id = order.customer_id";

                    //Gotta finish the query and create the tables to display the match
                    //Do query and finish order

                    if (cmd.ExecuteNonQuery() == 0)
                        MatchError.Visible = true;
                }
            }
            catch (SystemException)
            {

            }
        }

        //You just have to figure out the query
        protected void OpenOrderHistory(object sender, EventArgs e)
        {
         /*   string customerEmail = pEmailTxtbox.Text;
            //find custId for that email anddd yeah
            //tbh I feel like we should use a gridview, datasource it and data bind it and call it a day
            using (SqlConnection restaurantConnection = new SqlConnection(connectionString))
            {
                restaurantConnection.Open();
                SqlCommand cmd = restaurantConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //Write the query
                cmd.CommandText = "";
                SqlDataReader dr = cmd.ExecuteReader();
                orderHistoryGridview.DataSource = dr;
                orderHistoryGridview.DataBind();
                restaurantConnection.Close();
            }
            orderHistoryGridview.Visible = true;*/
        }
    }
}