@ModelType OpenQbit.TrakingManagement.Common.Models.Vehicle
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
