@ModelType OpenQbit.TrakingManagement.Common.Models.Resource
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Resource</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.UserID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GPSLocation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GPSLocation)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ResourceID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
