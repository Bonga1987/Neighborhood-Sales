<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Add-Product.aspx.cs" Inherits="GroupProject_Web.Add_Product" %>
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
                        <div class="contact_form_title">Add Product</div>

                        <form id="contact_form" runat="server">
                            <div class="contact_form_inputs d-flex flex-md-row flex-column justify-content-between align-items-between">
                                <input type="text" id="prod_name" class="contact_form_name input_field" placeholder="Product Name" required="required" data-error="Product Name is required." runat="server">
                                <input type="text" id="prod_price" class="contact_form_email input_field" placeholder="Product Price" required="required" data-error="Product Price is required." runat="server">
                                <input type="text" id="prod_desc" class="contact_form_date input_field" placeholder="Product Description" runat="server" required="required" data-error="Product Description is required.">
                            
                            </div>
                            <div class="contact_form_inputs d-flex flex-md-row flex-column justify-content-between align-items-between">
                                <input type="text" id="prod_cat" class="contact_form_phone input_field" placeholder="Product Category" runat="server">
                                <input type="text" id="Quantity" class="contact_form_name input_field" placeholder="Product Quantity" required="required" data-error="Quantity is required." runat="server">
                                <input type="text" id="Brand" class="contact_form_name input_field" placeholder="Product Brand" required="required" data-error="Brand is required." runat="server">
                            </div>
                            
                           

                            <asp:Button ID="Add" runat="server" Text="Add Product" type="submit" class="button contact_submit_button"  />

                        </form>
                        <br />
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
