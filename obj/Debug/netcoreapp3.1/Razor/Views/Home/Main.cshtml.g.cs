#pragma checksum "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b12c7751be36d588171fdf2f9c9f9f5a90f095c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12c7751be36d588171fdf2f9c9f9f5a90f095c2", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f55e906a5633bee239e13d6bf3a32417c57e856", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12c7751be36d588171fdf2f9c9f9f5a90f095c24299", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Home</title>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script>
       $(document).ready(function() {

           

            $( "".gallery"" ).hover(function() {
                    var id = $(this).attr('id');
                    console.log(""this is the id:"", id)
                    $( this ).css(""opacity"","".7"");
                    $( this ).append( $( ""<button onclick=\""location.href='/addfavorite/""+id+""'\"" type=\""button\"" class=\""star\""><svg class=\""bi bi-star-fill\"" width=\""2em\"" height=\""2em\"" viewBox=\""0 0 16 16\"" fill=\""currentColor\"" xmlns=\""http://www.w3.org/2000/svg\""> <path d=\""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.38");
                WriteLiteral(@"9 2.256z\""/></svg></button>"" ) );
                    $( this ).append( $( ""<button onclick=\""location.href='/details/""+id+""'\"" type=\""button\"" class=\""clipboard\""><svg class=\""bi bi-file-text\"" width=\""2em\"" height=\""2em\"" viewBox=\""0 0 16 16\"" fill=\""currentColor\"" xmlns=\""http://www.w3.org/2000/svg\""><path fill-rule=\""evenodd\"" d=\""M4 1h8a2 2 0 012 2v10a2 2 0 01-2 2H4a2 2 0 01-2-2V3a2 2 0 012-2zm0 1a1 1 0 00-1 1v10a1 1 0 001 1h8a1 1 0 001-1V3a1 1 0 00-1-1H4z\"" clip-rule=\""evenodd\""/><path fill-rule=\""evenodd\"" d=\""M4.5 10.5A.5.5 0 015 10h3a.5.5 0 010 1H5a.5.5 0 01-.5-.5zm0-2A.5.5 0 015 8h6a.5.5 0 010 1H5a.5.5 0 01-.5-.5zm0-2A.5.5 0 015 6h6a.5.5 0 010 1H5a.5.5 0 01-.5-.5zm0-2A.5.5 0 015 4h6a.5.5 0 010 1H5a.5.5 0 01-.5-.5z\"" clip-rule=\""evenodd\""/></svg>"" ) );
                    $( this ).append( $( ""<button onclick=\""location.href='/addhide/""+id+""'\"" type=\""button\"" class=\""trash\""><svg class=\""bi bi-trash-fill\"" width=\""2em\"" height=\""2em\"" viewBox=\""0 0 16 16\"" fill=\""currentColor\"" xmlns=\""http://www.");
                WriteLiteral(@"w3.org/2000/svg\""><path fill-rule=\""evenodd\"" d=\""M2.5 1a1 1 0 00-1 1v1a1 1 0 001 1H3v9a2 2 0 002 2h6a2 2 0 002-2V4h.5a1 1 0 001-1V2a1 1 0 00-1-1H10a1 1 0 00-1-1H7a1 1 0 00-1 1H2.5zm3 4a.5.5 0 01.5.5v7a.5.5 0 01-1 0v-7a.5.5 0 01.5-.5zM8 5a.5.5 0 01.5.5v7a.5.5 0 01-1 0v-7A.5.5 0 018 5zm3 .5a.5.5 0 00-1 0v7a.5.5 0 001 0v-7z\"" clip-rule=\""evenodd\""/></svg>"" ) );
                    $( this ).append( $( ""<button onclick=\""location.href='/email/""+id+""'\"" type=\""button\"" class=\""envelope\""><svg class=\""bi bi-envelope-fill\"" width=\""2em\"" height=\""2em\"" viewBox=\""0 0 16 16\"" fill=\""currentColor\"" xmlns=\""http://www.w3.org/2000/svg\""><path d=\""M.05 3.555L8 8.414l7.95-4.859A2 2 0 0014 2H2A2 2 0 00.05 3.555zM16 4.697l-5.875 3.59L16 11.743V4.697zm-.168 8.108L9.157 8.879 8 9.586l-1.157-.707-6.675 3.926A2 2 0 002 14h12a2 2 0 001.832-1.195zM0 11.743l5.875-3.456L0 4.697v7.046z\""/></svg>""));
                    }, function() {
                    $( this ).find( ""button"" ).remove();
                    $( this ).css(""opa");
                WriteLiteral(@"city"",""1"");
                }
            );
        });

    </script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">   
    <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"" >
    <style>
        .star {
            padding-top: 5px;
            background-color: lightsteelblue;
            border-radius: 12px;
            position: absolute;
            top:5px; 
            left:170px;
            opacity: 1;
        }
        .trash {
            padding-top: 5px;
            background-color: lightsteelblue;
            border-radius: 12px;
            position: absolute;
            top:195px; 
            left:170px;
            opacity: 1;
        }
        .clipboard {
            padding-top: 5px;
            background-color: lightsteelblue;
            border-radius: 12px;
            position: absolute;
            top:195px; 
            left:5px;
            opacity: 1;
      ");
                WriteLiteral(@"  }
        .envelope{
            padding-top: 5px;
            background-color: lightsteelblue;
            border-radius: 12px;
            position: absolute;
            top:195px; 
            left:88px;
            opacity: 1;
        }
        .container {
            margin: 50px auto;
        }
        .gallery{
            width: 220px;
            height: 241px;
            display: inline-block;
            margin: 15px;
            position:relative;
        }
        .gallery img {
            width: 220px;
            height: 241px; 
            border-radius: 10px;
        }

    </style>
    <title>Sucess</title>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12c7751be36d588171fdf2f9c9f9f5a90f095c210316", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <nav class=""navbar-inverse navbar-fixed-top"">
        <ul class=""nav nav-tabs nav-left-justified"">
            <li id=""home"" class=""active""><a data-toggle=""tab"" href=""/main"">Home</a></li>
            <li id=""add""><a data-toggle=""tab"" href=""/newrecipe"">Add New Recipe</a></li>
            <li id=""saved""><a data-toggle=""tab"" href=""/savedRecipes"">Saved Recipes</a></li>
            <li id=""edit""><a data-toggle=""tab""");
                BeginWriteAttribute("href", " href=\"", 5411, "\"", 5454, 2);
                WriteAttributeValue("", 5418, "/editUser/", 5418, 10, true);
#nullable restore
#line 97 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
WriteAttributeValue("", 5428, Model.RegisterUser.UserId, 5428, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit Profile</a></li>\r\n            <li id=\"logout\"><a data-toggle=\"tab\" href=\"/logout\">Log Out</a></li>\r\n");
                WriteLiteral(@"        </ul>
    </nav>  

    <div class=""hero-image"">
        <div class=""hero-text"">
            <h1 style=""font-size:50px"">Welcome to the Cookbook!</h1>
            <h3>Where you can manage your recipes!</h3>
        </div>
    </div>

 
        <div class=""container"">

            <h1>Welcome ");
#nullable restore
#line 120 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
                   Write(Model.RegisterUser.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</h1>\r\n\r\n");
#nullable restore
#line 122 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
             foreach (var Pic in @Model.RecipeList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"gallery\"");
                BeginWriteAttribute("id", " id = \"", 6444, "\"", 6464, 1);
#nullable restore
#line 124 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
WriteAttributeValue("", 6451, Pic.RecipeId, 6451, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 6494, "\"", 6516, 1);
#nullable restore
#line 126 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
WriteAttributeValue("", 6500, Pic.RecipeImage, 6500, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 6517, "\"", 6538, 1);
#nullable restore
#line 126 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
WriteAttributeValue("", 6523, Pic.RecipeName, 6523, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n                    <p style=\"text-align: center\">");
#nullable restore
#line 127 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
                                             Write(Pic.RecipeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 129 "C:\Users\jenny\OneDrive\Desktop\RecipeBook\RecipeBook\Views\Home\Main.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>  \r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
