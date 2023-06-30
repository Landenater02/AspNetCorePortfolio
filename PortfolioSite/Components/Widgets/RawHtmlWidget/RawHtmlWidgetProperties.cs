using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using PortfolioSite.Components.PageBuilder.Widgets.RawHtmlWidget;

[assembly: RegisterWidget("Components.Widgets.RawHtmlWidget",
                         "Insert raw html",
                         typeof(RawHtmlWidgetProperties),
                         customViewName: "~/Components/Widgets/RawHtmlWidget/_RawHtmlWidget.cshtml")]

namespace PortfolioSite.Components.PageBuilder.Widgets.RawHtmlWidget
{
    public class RawHtmlWidgetProperties : IWidgetProperties
    {

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Raw Html")]
        public string Html { get; set; } = "html";
    }
}