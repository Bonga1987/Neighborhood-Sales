<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GroupProject_Web.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="description" content="OneTech shop project">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="styles/bootstrap4/bootstrap.min.css">
    <link href="plugins/fontawesome-free-5.0.1/css/fontawesome-all.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" type="text/css" href="styles/contact_styles.css">
    <link rel="stylesheet" type="text/css" href="styles/contact_responsive.css">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Contact Form -->

    <div class="contact_form">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 offset-lg-1">
                    <div class="contact_form_container">
                        <div class="contact_form_title">User Registration</div>

                        <form id="contact_form" runat="server">
                            <div class="contact_form_inputs d-flex flex-md-row flex-column justify-content-between align-items-between">
                                <input type="text" id="contact_form_name" class="contact_form_name input_field" placeholder="Your name" required="required" data-error="Name is required." runat="server">
                                <input type="email" id="contact_form_email" class="contact_form_email input_field" placeholder="Your email" required="required" data-error="Email is required." runat="server">
                                <input type="date" id="contact_form_date" class="contact_form_date input_field" placeholder="Your date of birth" runat="server">
                            </div>
                            <div class="contact_form_inputs d-flex flex-md-row flex-column justify-content-between align-items-between">
                                <input type="text" id="contact_form_phone" class="contact_form_phone input_field" placeholder="Your phone number" runat="server">
                                <input type="password" id="password1" class="contact_form_name input_field" placeholder="Your Password" required="required" data-error="password is required." runat="server">
                                <input type="password" id="password2" class="contact_form_name input_field" placeholder="Confirm Password" required="required" data-error="password is required." runat="server">
                            </div>
                            <div class="contact_form_inputs d-flex flex-md-row flex-column justify-content-between align-items-between" runat="server" id="typeTab" visible="false">
                                <select class="standard_dropdown top_bar_dropdown" aria-label="Default select example" runat="server" id="type">
                                    
                                    <option selected>Customer</option>
                                    <option value="Man"> Ecommerce Manager</option>
                                </select>
                            </div>

                            <div class="clear">
                                <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            </div>


                            <asp:Button ID="btnRegister" runat="server" Text="Register" type="submit" class="button contact_submit_button" OnClick="btnRegister_Click" />

                        </form>
                        <br />
                    </div>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
