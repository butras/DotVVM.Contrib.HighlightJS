using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;

namespace DotVVM.Contrib.HighlightJS
{
    /// <summary>
    /// Renders a HighlightJS widget.
    /// </summary>
    [ControlMarkupOptions(AllowContent = false)]
    public class HighlightJS : HtmlGenericControl
    {

        public string Code
        {
            get { return (string)GetValue(CodeProperty); }
            set { SetValue(CodeProperty, value); }
        }
        public static readonly DotvvmProperty CodeProperty = DotvvmProperty.Register<string, HighlightJS>(c => c.Code, null);

        public string Language
        {
            get { return (string)GetValue(LanguageProperty); }
            set { SetValue(LanguageProperty, value); }
        }
        public static readonly DotvvmProperty LanguageProperty = DotvvmProperty.Register<string, HighlightJS>(c => c.Language, null);

        public bool? LineNumbersEnabled
        {
            get { return (bool?)GetValue(LineNumbersEnabledProperty); }
            set { SetValue(LineNumbersEnabledProperty, value); }
        }
        public static readonly DotvvmProperty LineNumbersEnabledProperty = DotvvmProperty.Register<bool?, HighlightJS>(c => c.LineNumbersEnabled, null);


        public HighlightJS() : base("code")
        {

        }

        protected override void OnPreRender(IDotvvmRequestContext context)
        {
            context.ResourceManager.AddRequiredResource("dotvvm.contrib.HighlightJS");

            base.OnPreRender(context);
        }

        protected override void AddAttributesToRender(IHtmlWriter writer, IDotvvmRequestContext context)
        {            
            writer.AddAttribute("class", Language);            
            
            writer.AddKnockoutDataBind("dotvvm-contrib-HighlightJS", this, CodeProperty, renderEvenInServerRenderingMode: true, nullBindingAction: () =>
            {
                writer.AddAttribute("value", Code);
            });
            
            writer.AddKnockoutDataBind("dotvvm-contrib-HighlightJS-LineNumbers", this, LineNumbersEnabledProperty, renderEvenInServerRenderingMode: true, nullBindingAction: () =>
            {
                if (IsPropertySet(LineNumbersEnabledProperty))
                    writer.AddAttribute("linenumbers", LineNumbersEnabled.ToString().ToLower());
            });

            base.AddAttributesToRender(writer, context);
        }

        protected override void RenderBeginTag(IHtmlWriter writer, IDotvvmRequestContext context)
        {            
            writer.RenderBeginTag(TagName);
        }

        protected override void RenderContents(IHtmlWriter writer, IDotvvmRequestContext context)
        {
            // this method is left blank intentionally
        }

        protected override void RenderEndTag(IHtmlWriter writer, IDotvvmRequestContext context)
        {
            // this method is left blank intentionally
            writer.RenderEndTag();
        }
    }
}
