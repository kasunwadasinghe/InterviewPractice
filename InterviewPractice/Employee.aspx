<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="InterviewPractice.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divGrid" style="padding: 10px; width: 1131px">
        <asp:UpdatePanel ID="updpnlEmployee" runat="server">
            <ContentTemplate>
                <asp:GridView ID="grdEmployee" runat="server"
                    ShowHeaderWhenEmpty ="True"
                    AllowPaging="True"
                    AutoGenerateColumns="False"
                    OnPageIndexChanging="grdEmployee_PageIndexChanging"
                    DataKeyNames="Id"
                    OnRowDataBound="grdEmployee_RowDataBound"
                    OnRowCommand="grdEmployee_RowCommand"
                    OnRowEditing="grdEmployee_RowEditing"
                    OnRowCancelingEdit="grdEmployee_RowCancelingEdit"
                    OnRowUpdating="grdEmployee_RowUpdating"
                    OnRowDeleting="grdEmployee_RowDeleting"
                    EmptyDataText="No Record Found" 
                    Width="1128px"
                    ShowFooter="true"
                    BorderStyle ="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    >
                    <Columns>
                        <asp:TemplateField HeaderText="First Name">
                            <ItemTemplate>
                                <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("First_Name")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtFirstName" runat="server" Text='<%#Eval("First_Name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Last Name">
                            <ItemTemplate>
                                <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("Last_Name")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtLastName" runat="server" Text='<%#Eval("Last_Name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contact No">
                            <ItemTemplate>
                                <asp:Label ID="lblContact" runat="server" Text='<%#Eval("Contact_No")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtContact" runat="server" Text='<%#Eval("Contact_No") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtContact" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email">
                            <ItemTemplate>
                                <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email_Address")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmail" runat="server" Text='<%#Eval("Email_Address") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                        <ItemTemplate>
                           <asp:Button ID="btnEdit" runat="server" Text='Edit' CommandName="Edit"></asp:Button>
                           <asp:Button ID="btnDelete" runat="server" Text='Delete' CommandName="Delete"></asp:Button>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btnSave" runat="server" Text='Save' CommandName="Update"></asp:Button>
                            <asp:Button ID="btnCancel" runat="server" Text='Cancel' CommandName="Cancel"></asp:Button>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btnAdd" runat="server" Text='Add' CommandName="cmdAdd" ></asp:Button>
                        </FooterTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>

    </div>

</asp:Content>
