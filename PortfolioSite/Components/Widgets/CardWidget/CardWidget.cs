
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using PortfolioSite.Components.Widgets.CardWidget;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Kentico.Components.Web.Mvc.FormComponents;
[assembly: RegisterWidget("Components.Widgets._CardWidget",
                         "Card Widget",
                         typeof(CardWidgetProperties),
                         customViewName: "~/Components/Widgets/CardWidget/_CardWidget.cshtml",IconClass = "icon-l-grid-3-2")]

namespace PortfolioSite.Components.Widgets.CardWidget
{
    

    
    public record CardWidgetProperties : IWidgetProperties  //the widget properties, [editing component] is the settings for the kentico admin 
    {
        // Defines a property and sets its default value
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Image Url")]
        public string ImgUrl { get; set; } = "/getmedia/17a343c7-2bda-4837-be38-8996f7b09da2/SSM_Health_logo.png";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Card Title")]
        public string CardTitle { get; set; } = "SSM Health";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Card Description")]
        public string CardDescription { get; set; } = "I performed style and maps work for SSM Health website";
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Link")]
        public string ButtonLink { get; set; } = "https://www.ssmhealth.com/";
    }

    
}

