Type.registerNamespace("timw255.Sitefinity.SuperForms.FormFields");

timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice = function (element) {
    timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.initializeBase(this, [element]);
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */
    initialize: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.callBaseMethod(this, 'dispose');
    }

    /* --------------------------------- public methods ---------------------------------- */

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice.registerClass('timw255.Sitefinity.SuperForms.FormFields.LogicalFormMultipleChoice', Telerik.Sitefinity.Web.UI.Fields.ChoiceField);