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
                <asp:TableCell ID="Nav_Match" runat="server" CssClass="navCell">
                    <asp:Button ID="Match_Button" runat="server" Text="LOVE MATCH" OnClick="Match_Button_Click" CssClass="nav_btn"/>
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
                    <asp:Label ID="Label1" runat="server" Text="We Are The Best Online Restaurant!" CssClass="title" ></asp:Label>
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

                <!-- Details panel which sucked the soul out of me-->
                <asp:Panel ID="Details_Panel" runat="server" Visible="False" Enabled="False" CssClass="panels">
                    <asp:Label ID="detailsPanelLabel" runat="server" Text="DETAILS" CssClass="title"></asp:Label>
                    <br />
                    <br />
                   
                    <asp:Panel ID="Table_Panel" runat="server" HorizontalAlign="left">
                    </asp:Panel>
                </asp:Panel>

                
                <asp:Panel ID="Menu_Panel" runat="server" Visible="False" Enabled="False" CssClass="panels">
                    <asp:Label ID="menuPanelLabel" runat="server" Text="MENU" CssClass="title"></asp:Label>
                    <br />
                    <br />
                    <asp:Panel ID="Menu_Control_Panel" runat="server" HorizontalAlign="center">
                    </asp:Panel>
                    
                </asp:Panel>

               

               
                <asp:Panel ID="SignIn_Panel" runat="server" Visible="False" Enabled="False" BackColor="#FFCCCC" CssClass="panels">
                        <asp:Label runat="server" ID="signInUnable" ForeColor="Red"></asp:Label><br />
                        <asp:Label ID="email_lbl" runat="server" Text="EMAIL"></asp:Label>
                        <br />
                        <asp:TextBox ID="Email_Txt" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="password_lbl" runat="server" Text="PASSWORD"></asp:Label>
                        <br />
                        <asp:TextBox ID="Password_Txt" runat="server" TextMode="Password"></asp:TextBox>
                        <br /><br />
                        <asp:Button ID="SignInBtn" runat="server" Text="Sign In"  OnClick="OnSignInClick" CssClass="aut_btn"  />
                        <br />
                        <br />
                        <asp:Label ID="noAccount_lbl" runat="server" Text="Don't have an account? "></asp:Label>
                    <asp:LinkButton ID="SignUpLinkButton" runat="server" OnClick="OnSignUpLinkClick">Sign Up!</asp:LinkButton>
                    </asp:Panel>

                <!--Sign up panel-->
                <asp:Panel ID="SignUp_Panel" runat="server" Visible="False" Enabled="False" BackColor="#FFCCCC" CssClass="panels" >
                        
                    <table class="infoTables">
                        <tr>
                            <td><asp:Label ID="firstNameLbl" runat="server" Text="FIRST NAME:"></asp:Label></td>
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

                <!--Customer's profile space-->
                <asp:Panel ID="Profile_Panel" runat="server" Visible="False" Enabled="False" BackColor="#FFCCCC" CssClass="panels">
                    <asp:Label ID="profilePanelLabel" runat="server" Text="PROFILE" CssClass="title"></asp:Label>
                        <br/>
                        <br/>
                    <table class="infoTables">
                        <tr>
                            <td><asp:Label ID="pFirstNameLabel" runat="server" Text="First Name:"></asp:Label></td>
                            <td><asp:TextBox ID="pFirstNameTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="pEmailLabel" runat="server" Text="Email:"></asp:Label></td>
                            <td><asp:TextBox ID="pEmailTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="pLastNameLabel" runat="server" Text="Last Name:"></asp:Label></td>
                            <td><asp:TextBox ID="pLastNameTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="pAddressLabel" runat="server" Text="Address:"></asp:Label></td>
                            <td><asp:TextBox ID="pAddressTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="pPhoneLabel" runat="server" Text="Phone Number:"></asp:Label></td>
                            <td><asp:TextBox ID="pPhoneTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Label ID="pCityLabel" runat="server" Text="City:"></asp:Label></td>
                            <td><asp:TextBox ID="pCityTxtbox" runat="server" enabled="false"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="pGenderLabel" runat="server" Text="Gender:"></asp:Label></td>
                            <td><asp:TextBox ID="pGenderTxtbox" runat="server" enabled="false"></asp:TextBox>
                            <br />
                                <asp:DropDownList ID="pGenderDropDown" runat="server" enabled="false" Visible="false">
                                    <asp:ListItem Value="M" Text="Male"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Female"></asp:ListItem>
                                    <asp:ListItem Value="NB" Text="Non-Binary"></asp:ListItem>
                                    <asp:ListItem Value="OT" Text="Other/None"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td><asp:Label ID="pPasswordLabel" runat="server" Text="Password:"></asp:Label></td>
                            <td><asp:TextBox ID="pPasswordTxtBox" runat="server" Enabled="false"></asp:TextBox></td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="pEditButton" runat="server" Text="Edit" OnClick="OnEditClick" CssClass="aut_btn" Width="70px"  />
                    <asp:Button ID="pSaveButton" runat="server" Text="Save" onClick="onSaveClick" CssClass="aut_btn" enabled="false" Width="70px" />
                    <asp:Button ID="pDeleteButton" runat="server" Text="Delete" OnClick="OnDeleteClick" CssClass="aut_btn" Width="70px"  />
                    <br /><br />
                    
                    <asp:Panel ID="Panel2" runat="server" Visible="False" Enabled="False"></asp:Panel>
                </asp:Panel>


                
                <asp:Panel ID="Contact_Panel" runat="server" Visible="False" Enabled="False" CssClass="panels">
                    
                    <div id="locationsDiv">
                        <asp:Label ID="MontrealTitle" runat="server" Text="MONTREAL" CssClass="locationsTitle"></asp:Label><br />
                        <!--first Montreal Location-->
                        <asp:Label ID="MontrealStreet" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="MontrealCode" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="MontrealPhone" runat="server"  CssClass="locationsLines"></asp:Label><br /><br />
                        <!--Second Montreal Location-->
                        <asp:Label ID="MontrealStreet1" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="MontrealCode1" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="MontrealPhone1" runat="server"  CssClass="locationsLines"></asp:Label><br /><br />
                        <!--LaSalle Location-->
                        <asp:Label ID="LaSalleTitle" runat="server" Text="LASALLE" CssClass="locationsTitle"></asp:Label><br />
                        <asp:Label ID="LaSalleStreet" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LaSalleCode" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LaSallePhone" runat="server"  CssClass="locationsLines"></asp:Label><br /><br />
                        <!--Laval-->
                        <asp:Label ID="LavalTitle" runat="server" Text="LAVAL" CssClass="locationsTitle"></asp:Label><br />
                        <asp:Label ID="LavalStreet" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LavalCode" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LavalPhone" runat="server"  CssClass="locationsLines"></asp:Label><br /><br />
                        <!--Longueuil-->
                        <asp:Label ID="LongueuilTitle" runat="server" Text="LONGUEUIL" CssClass="locationsTitle"></asp:Label><br />
                        <asp:Label ID="LongueilStreet" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LongueilCode" runat="server"  CssClass="locationsLines"></asp:Label><br />
                        <asp:Label ID="LongueilPhone" runat="server"  CssClass="locationsLines"></asp:Label><br />
                    </div>
                    <div id="contactUs">
                        <br />
                        <asp:Label ID="commentEmailLable" runat="server" Text="Email: " CssClass="locationsTitle"></asp:Label>
                        <asp:TextBox ID="commentEmailtext" runat="server"></asp:TextBox>
                        <br /><br />
                        <asp:Label ID="commentLable" runat="server" Text="Comments or Suggestions: " CssClass="locationsTitle"></asp:Label><br /><br />
                        <asp:TextBox ID="commentText" runat="server"  Width="50%" Rows="10" TextMode="MultiLine"></asp:TextBox>
                        <br /><br />
                        <asp:Button ID="SubmitComment" runat="server" Text="Submit Comments!" OnClick="SubmitComment_Click"/><br /><br />
                        <asp:Label ID="SubmittedComment" runat="server" CssClass="locationsTitle"></asp:Label><br /><br />
                        <asp:Label ID="newsletterlbl" runat="server" Text="Also, download our latest deals!" CssClass="locationsTitle"></asp:Label><br />
                        <asp:Button ID="DownloadDeals" runat="server" Text="Download Deals!" OnClick="DownloadDeals_Click" /><br /><br />
                    </div>
                </asp:Panel>

                <asp:Panel runat="server" ID="MatchFindPanel" Visible="False" Enabled="False" CssClass="panels">
                    <asp:Label ID="MatchLbl" runat="server" Text="Enter your email and find your soulmate!" CssClass="locationsTitle"></asp:Label><br /><br />
                    <asp:TextBox ID="MatchTxt" runat="server"></asp:TextBox>
                    <asp:Button ID="FindBtn" runat="server" Text="Find My Match" OnClick="FindBtn_Click" />
                    <asp:Label ID="MatchError" runat="server" Text="We couldn't find your match :( Try creating an account!" ForeColor="Red" Visible="false"></asp:Label>
                </asp:Panel>
            </asp:Panel>
            
        </div>
    </form>
</body>
</html>
