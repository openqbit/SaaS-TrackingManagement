@ModelType IEnumerable(Of OpenQbit.TrakingManagement.Common.Models.Vehicle)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.GPSLocation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.VehicleID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.VehicleType)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.VehicleNO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TourNO)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GPSLocation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.VehicleID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.VehicleType)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.VehicleNO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TourNO)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ResourceID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ResourceID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ResourceID })
        </td>
    </tr>
Next

</table>
