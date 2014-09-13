using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Fluent.Modules.Toolboxes;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.Forms;
using timw255.Sitefinity.SuperForms.Localization;
using timw255.Sitefinity.SuperForms.FormFields;
using timw255.Sitefinity.SuperForms.FormControls;

namespace timw255.Sitefinity
{
    public sealed class Installer
    {
        public static void PreApplicationStart()
        {
            Bootstrapper.Initialized += (new EventHandler<ExecutedEventArgs>(Installer.Bootstrapper_Initialized));
        }

        private static void Bootstrapper_Initialized(object sender, ExecutedEventArgs e)
        {
            if (e.CommandName != "RegisterRoutes" || !Bootstrapper.IsDataInitialized)
            {
                return;
            }

            Res.RegisterResource<LogicalFormsResources>();
            InstallVirtualPaths();
            InstallFormWidgets();
        }

        private static void InstallVirtualPaths()
        {
            SiteInitializer initializer = SiteInitializer.GetInitializer();
            var virtualPathConfig = initializer.Context.GetConfig<VirtualPathSettingsConfig>();
            var virtualPathElement = new VirtualPathElement(virtualPathConfig.VirtualPaths)
            {
                VirtualPath = "~/timw255/" + "*",
                ResolverName = "EmbeddedResourceResolver",
                ResourceLocation = "timw255.Sitefinity"
            };
            if (!virtualPathConfig.VirtualPaths.ContainsKey("~/timw255/" + "*"))
            {
                virtualPathConfig.VirtualPaths.Add(virtualPathElement);
                Config.GetManager().SaveSection(virtualPathConfig);
            }
        }

        private static void InstallFormWidgets()
        {
            App.WorkWith().Module(FormsModule.ModuleName).Install()
                .Toolbox(CommonToolbox.PageWidgets)
                    .LoadOrAddSection("SuperForms")
                    .SetTitle("SuperForms")
                    .SetDescription("SuperForms")
                    .LoadOrAddWidget<LogicalFormsControl>("LogicalFormsControl")
                            .SetTitle("SuperForms Form")
                            .SetDescription("SuperForms Form control")
                            .SetCssClass("sfFormsIcn")
                    .Done();

            App.WorkWith().Module(FormsModule.ModuleName).Install()
                .Toolbox(CommonToolbox.FormWidgets)
                    .LoadOrAddSection("SuperForms")
                        .SetTitle("SuperForms Controls")
                        .SetDescription("SuperForms field conrols")
                        .LoadOrAddWidget<LogicalFormCheckboxes>("LogicalFormCheckboxes")
                            .SetTitle("Super Checkboxes")
                            .SetDescription("SuperForms Checkboxes field")
                            .SetCssClass("sfCheckboxesIcn")
                        .Done()
                        .LoadOrAddWidget<LogicalFormDropDownList>("LogicalFormDropDownList")
                            .SetTitle("Super DropDownList")
                            .SetDescription("SuperForms DropDownList field")
                            .SetCssClass("sfDropdownIcn")
                        .Done()
                        .LoadOrAddWidget<LogicalFormMultipleChoice>("LogicalFormMultipleChoice")
                            .SetTitle("Super MultipleChoice")
                            .SetDescription("SuperForms MultipleChoice field")
                            .SetCssClass("sfMultipleChoiceIcn")
                        .Done()
                        .LoadOrAddWidget<LogicalFormParagraphTextBox>("LogicalFormParagraphTextBox")
                            .SetTitle("Super ParagraphTextBox")
                            .SetDescription("SuperForms ParagraphTextBox field")
                            .SetCssClass("sfParagraphboxIcn")
                        .Done()
                        .LoadOrAddWidget<LogicalFormTextBox>("LogicalFormTextBox")
                            .SetTitle("Super TextBox")
                            .SetDescription("SuperForms TextBox field")
                            .SetCssClass("sfTextboxIcn")
                        .Done()
                    .Done()
                .Done();
        }
    }
}