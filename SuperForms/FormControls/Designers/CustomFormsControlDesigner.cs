using timw255.Sitefinity.SuperForms.FormFields.Designers.Views;
using System.Collections.Generic;
using Telerik.Sitefinity.Modules.Forms.Web.UI.Designers;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Sitefinity.Web.UI;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace timw255.Sitefinity.SuperForms.FormControls.Designers
{
    public class CustomFormsControlDesigner : FormsControlDesigner
    {
        public override string LayoutTemplatePath
        {
            get
            {
                return "~/timw255/timw255.Sitefinity.SuperForms.FormControls.Designers.CustomFormsControlDesigner.ascx";
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }

        public override IEnumerable<ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences());

            scripts.Add(new ScriptReference("timw255.Sitefinity.SuperForms.FormControls.Designers.CustomFormsControlDesigner.js", "timw255.Sitefinity"));

            return scripts.ToArray();
        }
    }
}