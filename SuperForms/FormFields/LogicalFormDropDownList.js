Type.registerNamespace("timw255.Sitefinity.SuperForms.FormFields");

timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList = function (element) {
    timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.initializeBase(this, [element]);
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */
    initialize: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.callBaseMethod(this, 'dispose');
    }

    /* --------------------------------- public methods ---------------------------------- */

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList.registerClass('timw255.Sitefinity.SuperForms.FormFields.LogicalFormDropDownList', Telerik.Sitefinity.Web.UI.Fields.ChoiceField);