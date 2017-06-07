@ModelType OpenQbit.TrakingManagement.Common.Models.Root
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Root</h4>
    <hr />
    <dl class="dl-horizontal">
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.RootID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
