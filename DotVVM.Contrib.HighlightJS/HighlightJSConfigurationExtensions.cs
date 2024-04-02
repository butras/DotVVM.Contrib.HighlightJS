using System.Reflection;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;

namespace DotVVM.Contrib.HighlightJS
{
    public static class HighlightJSConfigurationExtensions
    {

        public static void AddContribHighlightJSConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(HighlightJS).Assembly.GetName().Name,
                Namespace = typeof(HighlightJS).Namespace,
                TagPrefix = "dc"
            });

            // register additional resources for the control and set up dependencies
            config.Resources.Register("dotvvm.contrib.HighlightJS", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(HighlightJS).GetTypeInfo().Assembly, "DotVVM.Contrib.HighlightJS.Scripts.DotVVM.Contrib.HighlightJS.js"),
                Dependencies = new[] { "dotvvm", "HighlightJS", "HighlightJS-Cisco", "HighlightJS-LineNumbers", "HighlightJS.css" }
            });
            config.Resources.Register("HighlightJS", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(HighlightJS).GetTypeInfo().Assembly, "DotVVM.Contrib.HighlightJS.Scripts.highlight.min.js"),
            });
            config.Resources.Register("HighlightJS-Cisco", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(HighlightJS).GetTypeInfo().Assembly, "DotVVM.Contrib.HighlightJS.Scripts.highlight.cisco.min.js"),
                Dependencies = new[] { "HighlightJS" }
            });
            config.Resources.Register("HighlightJS-LineNumbers", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(HighlightJS).GetTypeInfo().Assembly, "DotVVM.Contrib.HighlightJS.Scripts.highlight-line-numbers.min.js"),
            });
            config.Resources.Register("HighlightJS.css", new StylesheetResource()
            {
                Location = new EmbeddedResourceLocation(typeof(HighlightJS).GetTypeInfo().Assembly, "DotVVM.Contrib.HighlightJS.Styles.highlight_theme.min.css")
            });
        }

    }
}
