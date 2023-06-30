
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using PortfolioSite.Components.Widgets.AboutMeWidget;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Kentico.Components.Web.Mvc.FormComponents;
[assembly: RegisterWidget("Components.Widgets._AboutMeWidget",
                         "AboutMe Widget",
                         typeof(AboutMeWidgetProperties),
                         customViewName: "~/Components/Widgets/AboutMeWidget/_AboutMeWidget.cshtml",IconClass = "icon-l-grid-3-2")]

namespace PortfolioSite.Components.Widgets.AboutMeWidget
{
    

    
    public record AboutMeWidgetProperties : IWidgetProperties  //the widget properties, [editing component] is the settings for the kentico admin 
    {
        // Defines a property and sets its default value
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Image Url: ")]
        public string ImgUrl { get; set; } = "/getmedia/b21086e1-167b-43cc-9ead-fb9795ff43b3/AboutMePageMusical.jpg";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title: ")]
        public string Title { get; set; } = "Guys and Dolls";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Description: ")]
        public string Description { get; set; }= "I have been involved in theater production since middle school and have been fascinated by it for as long as I could remember.I absolutely adore being on stage with the people I love.";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Subtitle (optional):")]
        public string Subtitle { get; set; } = "Guys and Dolls, ONHS 2022";

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 4, Label = "Slide show?:")]
        public bool SlideShow { get; set; } = false;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Image Alt:")]
        public string Alt { get; set; } = "Guys and Dolls Musical";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Image 2 (if Slide Show):")]
        public string Image2 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Image 3 (if Slide Show):")]
        public string Image3 { get; set; }


    }


}

