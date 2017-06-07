@ModelType OpenQbit.TrakingManagement.Common.Models.RootDetail
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>RootDetail</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RootID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RootID)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.RootDetailID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
