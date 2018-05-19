﻿<script type="text/javascript">
    function UpdateGridView() {
        PrepareValidationScripts();

        var validator = $.data($('#frmProduct')[0], 'validator');
        if (validator.form())
            grid.UpdateEdit();
    }

    function PrepareValidationScripts() {
        var form = $('#frmProduct');
        if (form.executed)
            return;

        form.removeData("validator");
        $.validator.unobtrusive.parse(document);
        form.executed = true;
    }
</script>

@Html.Action("GridViewPartial", "Home")