using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace timw255.Sitefinity.SuperForms.Localization
{
    public class LogicalFormsResources : Resource
    {

        public LogicalFormsResources()
        {
        }

        public LogicalFormsResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        /// <summary>
        /// 'Hide' action option text
        /// </summary>
        [ResourceEntry("HideActionOptionText", Value = "Hide", Description = "'Hide' action option text", LastModified = "2014/07/07")]
        public string HideActionOptionText
        {
            get { return this["HideActionOptionText"]; }
        }

        /// <summary>
        /// 'Show' action option text
        /// </summary>
        [ResourceEntry("ShowActionOptionText", Value = "Show", Description = "'Show' action option text", LastModified = "2014/07/07")]
        public string ShowActionOptionText
        {
            get { return this["HideActionOptionText"]; }
        }

        /// <summary>
        /// 'Any' bool option text
        /// </summary>
        [ResourceEntry("AnyBoolOptionText", Value = "Any", Description = "'Any' bool option text", LastModified = "2014/07/07")]
        public string AnyBoolOptionText
        {
            get { return this["AnyBoolOptionText"]; }
        }

        /// <summary>
        /// 'All' bool option text
        /// </summary>
        [ResourceEntry("AllBoolOptionText", Value = "All", Description = "'All' bool option text", LastModified = "2014/07/07")]
        public string AllBoolOptionText
        {
            get { return this["AllBoolOptionText"]; }
        }

        /// <summary>
        /// 'this field if' text
        /// </summary>
        [ResourceEntry("IfLabelText", Value = "this field if", Description = "'this field if' text", LastModified = "2014/07/07")]
        public string IfLabelText
        {
            get { return this["IfLabelText"]; }
        }

        /// <summary>
        /// 'of the following criteria match' text
        /// </summary>
        [ResourceEntry("OfTheFollowingCriteriaMatch", Value = "of the following criteria match.", Description = "'of the following criteria match' text", LastModified = "2014/07/07")]
        public string OfTheFollowingCriteriaMatch
        {
            get { return this["OfTheFollowingCriteriaMatch"]; }
        }

        /// <summary>
        /// Custom Logic view title
        /// </summary>
        [ResourceEntry("ViewTitle", Value = "Logic", Description = "Custom Logic view title", LastModified = "2014/07/07")]
        public string ViewTitle
        {
            get { return this["ViewTitle"]; }
        }

        /// <summary>
        /// 'Use conditional logic' label text
        /// </summary>
        [ResourceEntry("UseConditionalLogicLabel", Value = "Use conditional logic", Description = "'Use conditional logic' label text", LastModified = "2014/07/07")]
        public string UseConditionalLogicLabel
        {
            get { return this["UseConditionalLogicLabel"]; }
        }

        /// <summary>
        /// 'Add' button text
        /// </summary>
        [ResourceEntry("AddButtonText", Value = "Add", Description = "'Add' button text", LastModified = "2014/07/07")]
        public string AddButtonText
        {
            get { return this["AddButtonText"]; }
        }

        /// <summary>
        /// 'Remove' button text
        /// </summary>
        [ResourceEntry("RemoveButtonText", Value = "Remove", Description = "'Remove' button text", LastModified = "2014/07/07")]
        public string RemoveButtonText
        {
            get { return this["RemoveButtonText"]; }
        }
    }
}