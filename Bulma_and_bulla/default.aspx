<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Bulma_and_bulla._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BULMA&BULLA</title>
    <link rel="stylesheet" href="Restaurant_Style.css" />
    <style type="text/css">
        .nav_bar {}
    </style>
</head>
<body>
    <form id="MainForm" runat="server">
        <nav id="page_header">
            <br /><br />
            <asp:Label ID="Page_Title" runat="server" Text="BULMA &amp; BULLA" CssClass="title" ForeColor="#359E6B"></asp:Label><br />
            <asp:Table ID="Navigation_Table" runat="server" CssClass="nav_bar" BackColor="#FF9900" Font-Bold="True" Font-Italic="True" ForeColor="#3333CC" Height="43px">
            <asp:TableRow runat="server">
                <asp:TableCell  runat="server" CssClass="navCell" ID="Nav_Home"  >
                    <asp:Button ID="Home_Btn" runat="server" Text="HOME"  OnClick="OnHomeClick" CssClass="nav_btn"  />
                </asp:TableCell>
                <asp:TableCell ID="Nav_About" runat="server" CssClass="navCell">
                    <asp:Button ID="About_Btn" runat="server" Text="ABOUT"  OnClick="OnAboutClick" CssClass="nav_btn"  />
                </asp:TableCell>
                <asp:TableCell ID="Nav_Menu" runat="server" CssClass="navCell">
                    <asp:Button ID="Menu_Btn" runat="server" Text="MENU"  OnClick="OnMenuClick" CssClass="nav_btn" />
                </asp:TableCell>
                <asp:TableCell ID="Nav_Cust" runat="server" CssClass="navCell">
                    <asp:Button ID="Cust_Btn" runat="server" Text="CUSTOMER"  OnClick="OnCustClick" CssClass="nav_btn"/>
                </asp:TableCell>
                <asp:TableCell ID="Nav_Contact" runat="server" CssClass="navCell">
                    <asp:Button ID="Contact_Btn" runat="server" Text="CONTACT" OnClick="OnContactClick" CssClass="nav_btn"/>
                </asp:TableCell>
                <asp:TableCell ID="dine" runat="server">
                    <asp:ImageButton ID="Shopping_Kart" runat="server" CssClass="cart" Height="20px" Width="20px" ImageUrl="~/Images/order_icon.png"  OnClick="OnOrderClick" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </nav>
        

        <div>
            <asp:Panel ID="Current_Panel" runat="server" >
                <!-- Basically Sweetheart work on these panels as the content of each page-->
                <asp:Panel ID="Home_Panel" runat="server" CssClass="panels">
                    <asp:Label ID="Label1" runat="server" Text="We Are The best Asian Restaurant!" CssClass="title" ></asp:Label>
                    <br />
                    <asp:Image ID="food1" runat="server" ImageUrl="~/Images/food1.jpg" CssClass="homeImage" />
                    <br />
                    <asp:Image ID="dbeating" runat="server" ImageUrl="~/Images/food.jpg" CssClass="homeImage"/>
                    <br />
                    <asp:Image ID="food2" runat="server" ImageUrl="~/Images/food2.jpg" CssClass="homeImage"/>
                    <br />
                    <asp:Image ID="food3" runat="server" ImageUrl="~/Images/food3.jpg" CssClass="homeImage"/>
                    <br />
                </asp:Panel>

                <!-- Basically Sweetheart work on these panels as the content of each page-->
                <asp:Panel ID="About_Panel" runat="server" Visible="false" Enabled="False" CssClass="panels">
                    <asp:Label ID="Label2" runat="server" Text="ABOUT" CssClass="title"></asp:Label>
                    <asp:Table ID="PeopleTable" runat="server">
                        <asp:TableRow ID="BulmaRow" runat="server">
                            <asp:TableCell runat="server">
                                <asp:Image ID="BulmaIMG" runat="server" ImageUrl="~/Images/bulma.jpg" CssClass="aboutImage"/>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                Bulma is a brilliant scientist and the second daughter of Capsule Corporation's founder Dr. Brief. Apart from a scientist, Bulma is
                                Bulla's mother and a great cook!
                            </asp:TableCell>
                        </asp:TableRow>                    
                        <asp:TableRow ID="BullaRow" runat="server">
                            <asp:TableCell runat="server">
                                <asp:Image ID="BullaIMG" runat="server" ImageUrl="~/Images/bulla.jpg" CssClass="aboutImage"/>
                            </asp:TableCell>
                            <asp:TableCell runat="server"> Bulla is the daughter of Vegeta and Bulma,
                                making her a Saiyan and Earthling hybrid, like her older brother Trunks. She is also an excellent chef</asp:TableCell>
                        </asp:TableRow>
                        
                    </asp:Table>
                </asp:Panel>

                <!-- Basically Sweetheart work on these panels as the content of each page-->
                <asp:Panel ID="Menu_Panel" runat="server" Visible="False" Enabled="False" CssClass="panels">
                    <asp:Label ID="Label3" runat="server" Text="MENU" CssClass="title"></asp:Label>
                </asp:Panel>

                <!-- Basically Sweetheart work on these panels as the content of each page-->
                <asp:Panel ID="SignIn_Panel" runat="server" Visible="False" Enabled="False" BackColor="#FFCCCC" CssClass="panels">
                        <asp:Label runat="server" ID="signInUnable" ForeColor="Red"></asp:Label>
                        <asp:Label ID="email_lbl" runat="server" Text="EMAIL"></asp:Label>
                        <br />
                        <asp:TextBox ID="Email_Txt" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="password_lbl" runat="server" Text="PASSWORD"></asp:Label>
                        <br />
                        <asp:TextBox ID="Password_Txt" runat="server" TextMode="Password"></asp:TextBox>
                        <br /><br />
                        <asp:Button ID="SignIn" runat="server" Text="Sign In"  OnClick="OnSignInClick" CssClass="aut_btn"  />
                        <br />
                        <br />
                        <asp:Label ID="noAccount_lbl" runat="server" Text="Don't have an account? "></asp:Label>
                    <asp:LinkButton ID="SignUpLinkButton" runat="server" OnClick="OnSignUpLinkClick">Sign Up!</asp:LinkButton>
                    </asp:Panel>

                <asp:Panel ID="SignUp_Panel" runat="server" Visible="False" Enabled="False" BackColor="#FFCCCC" CssClass="panels" >
                        
                    <table id="signUpTable">
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="FIRST NAME:"></asp:Label></td>
                            <td><asp:TextBox ID="firstNameTxt" runat="server"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="EmailLbl" runat="server" Text="EMAIL:"></asp:Label></td>
                            <td><asp:TextBox ID="emailTxt" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="lastNamelbl" runat="server" Text="LAST NAME:"></asp:Label></td>
                            <td><asp:TextBox ID="lastNameTxt" runat="server"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="AddressLbl" runat="server" Text="ADDRESS:"></asp:Label></td>
                            <td><asp:TextBox ID="addressTxt" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="PhoneLbl" runat="server" Text="PHONE NUMBER:"></asp:Label></td>
                            <td><asp:TextBox ID="phoneTxt" runat="server" ></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="Citylbl" runat="server" Text="CITY:"></asp:Label></td>
                            <td><asp:TextBox ID="cityTxt" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="GenderLbl" runat="server" Text="GENDER:"></asp:Label></td>
                            <td>
                                <asp:DropDownList ID="genderDrop" runat="server">
                                    <asp:ListItem Value="M" Text="Male"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Female"></asp:ListItem>
                                    <asp:ListItem Value="NB" Text="Non-Binary"></asp:ListItem>
                                    <asp:ListItem Value="OT" Text="Other/None"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td><asp:Label ID="Passwordlbl" runat="server" Text="PASSWORD:"></asp:Label></td>
                            <td><asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="signUpBtn" runat="server" Text="Sign Up!"  OnClick="OnSignUpClick" CssClass="aut_btn"  />
                    <br /><br />
                    <asp:Label ID="SignedUpAlert" runat="server" ForeColor="Blue"></asp:Label>
                    
                    <asp:Panel ID="AuthenticatedSpace" runat="server" Visible="False" Enabled="False"></asp:Panel>
                </asp:Panel>

                <!-- Basically Sweetheart work on these panels as the content of each page-->
                <asp:Panel ID="Contact_Panel" runat="server" Visible="False" Enabled="False" CssClass="panels">
                    <asp:Label ID="Label5" runat="server" Text="CONTACT" CssClass="title"></asp:Label>
                </asp:Panel>

            </asp:Panel>
            
        </div>
    </form>
</body>
</html>
