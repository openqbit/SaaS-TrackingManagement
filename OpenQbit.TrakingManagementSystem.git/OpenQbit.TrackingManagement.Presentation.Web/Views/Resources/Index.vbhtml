@ModelType IEnumerable(Of OpenQbit.TrakingManagement.Common.Models.Resource)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ResourceID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ResourceID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ResourceID })
        </td>
    </tr>
Next

</table>
