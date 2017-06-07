@ModelType IEnumerable(Of OpenQbit.TrakingManagement.Common.Models.Tour)
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
            @Html.DisplayNameFor(Function(model) model.TourType)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Location)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Root)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Speed)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TourType)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Location)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Root)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Speed)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TourID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TourID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TourID })
        </td>
    </tr>
Next

</table>
