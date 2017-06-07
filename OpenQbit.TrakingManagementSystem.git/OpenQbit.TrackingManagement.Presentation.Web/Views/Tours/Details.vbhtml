@ModelType OpenQbit.TrakingManagement.Common.Models.Tour
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Tour</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TourType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TourType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Location)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Location)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Root)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Root)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Speed)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Speed)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TourID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
