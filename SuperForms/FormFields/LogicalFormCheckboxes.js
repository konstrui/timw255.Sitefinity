Type.registerNamespace("timw255.Sitefinity.SuperForms.FormFields");

timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes = function (element) {
    timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.initializeBase(this, [element]);
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */
    initialize: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.callBaseMethod(this, 'dispose');
    }

    /* --------------------------------- public methods ---------------------------------- */

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes.registerClass('timw255.Sitefinity.SuperForms.FormFields.LogicalFormCheckboxes', Telerik.Sitefinity.Web.UI.Fields.ChoiceField);