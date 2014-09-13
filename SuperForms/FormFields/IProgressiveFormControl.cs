using System;
using System.Collections.Generic;
using System.Text;
using Telerik.Sitefinity.Modules.Pages.PropertyPersisters;

namespace timw255.Sitefinity.SuperForms.FormFields
{
    internal interface IProgressiveFormControl
    {
        bool UsesProgressiveLogic { get; set; }

        bool IsProgressiveKeyField { get; set; }

        string ProgressiveCriteriaSet { get; set; }
    }
}