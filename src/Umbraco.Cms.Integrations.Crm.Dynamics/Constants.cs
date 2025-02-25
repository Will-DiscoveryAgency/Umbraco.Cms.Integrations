﻿
namespace Umbraco.Cms.Integrations.Crm.Dynamics
{
    public class Constants
    {
        public const string DynamicsOAuthConfigurationTable = "dynamicsOAuthConfiguration";

        public const string MigrationPlanName = "DynamicsOAuthMigrationPlan";

        public const string TargetStateName = "dynamicsOAuthConfiguration-db";

        public const string UmbracoCmsIntegrationsCrmDynamicsHostUrlKey = "Umbraco.Cms.Integrations.Crm.Dynamics.HostUrl";

        public const string UmbracoCmsIntegrationsCrmDynamicsApiPathKey = "Umbraco.Cms.Integrations.Crm.Dynamics.ApiPath";

        public const string AppPluginFolderPath = "~/App_Plugins/UmbracoCms.Integrations/Crm/Dynamics";

        public static class RenderingComponent
        {
            public const string DefaultViewPath = AppPluginFolderPath + "/Render/DynamicsForm.cshtml";

            public const string DefaultV8ViewPath = AppPluginFolderPath + "/Render/DynamicsFormV8.cshtml";
        }

        public static class EmbedAttribute
        {
            public const string DataFormBlockId = "data-form-block-id";

            public const string ContainerId = "id";

            public const string ContainerClass = "class";

            public const string DataWebsiteId = "data-website-id";

            public const string DataHostname = "data-hostname";
        }

        public static class Configuration
        {
            public const string Settings = "Umbraco:Cms:Integrations:Crm:Dynamics:Settings";
        }
    }
}
