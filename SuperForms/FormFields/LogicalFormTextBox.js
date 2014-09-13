Type.registerNamespace("timw255.Sitefinity.SuperForms.FormFields");

timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox = function (element) {
    timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.initializeBase(this, [element]);
};

timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */
    initialize: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.callBaseMethod(this, 'dispose');
    }

    /* --------------------------------- public methods ---------------------------------- */

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */
};

timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox.registerClass('timw255.Sitefinity.SuperForms.FormFields.LogicalFormTextBox', Telerik.Sitefinity.Web.UI.Fields.TextField);