﻿using DotVVM.Framework.Configuration;

namespace DotVVM.Contrib.GoogleAnalyticsJavascript
{
    public static class DotvvmConfigurationExtensions
    {

        public static void AddContribGoogleAnalyticsJavascriptConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(GoogleAnalyticsJavascript).Assembly.GetName().Name,
                Namespace = typeof(GoogleAnalyticsJavascript).Namespace,
                TagPrefix = "dc"
            });
        }

    }
}
