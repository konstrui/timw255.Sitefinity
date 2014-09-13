Type.registerNamespace("timw255.Sitefinity.SuperForms.FormFields");

timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox = function (element) {
    timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.initializeBase(this, [element]);
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */
    initialize: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.callBaseMethod(this, 'dispose');
    }

    /* --------------------------------- public methods ---------------------------------- */

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */
}

timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox.registerClass('timw255.Sitefinity.SuperForms.FormFields.LogicalFormParagraphTextBox', Telerik.Sitefinity.Web.UI.Fields.TextField);