﻿using DotVVM.Framework.Configuration;

namespace DotVVM.Contrib.PolicyView
{
    public static class DotvvmConfigurationExtensions
    {
        public static void AddContribPolicyViewConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(PolicyView).Assembly.GetName().Name,
                Namespace = typeof(PolicyView).Namespace,
                TagPrefix = "dc"
            });
        }
    }
}
