using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using timw255.Sitefinity;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("timw255.Sitefinity")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("timw255.Sitefinity")]
[assembly: AssemblyCopyright("Copyright © Tim Williamson 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("17420197-36a0-4562-a142-019ba38f1964")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
//[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: PreApplicationStartMethod(typeof(Installer), "PreApplicationStart")]

[assembly: WebResource("timw255.Sitefinity.Resources.logicalForms.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.Resources.logicalForms.min.js", "application/x-javascript")]

[assembly: WebResource("timw255.Sitefinity.SuperForms.FormControls.Designers.CustomFormsControlDesigner.js", "application/x-javascript")]

[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.Designers.Views.ConditionalLogicView.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.Designers.Views.ProgressiveProfilingView.js", "application/x-javascript")]

[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.min.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.min.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.min.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.min.js", "application/x-javascript")]
[assembly: WebResource("timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.min.js", "application/x-javascript")]