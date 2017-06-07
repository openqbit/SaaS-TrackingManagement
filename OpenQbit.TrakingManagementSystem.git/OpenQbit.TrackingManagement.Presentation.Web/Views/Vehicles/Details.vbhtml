@ModelType OpenQbit.TrakingManagement.Common.Models.Vehicle
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Vehicle</h4>
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.VehicleID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VehicleID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.VehicleType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VehicleType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.VehicleNO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VehicleNO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TourNO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TourNO)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ResourceID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
