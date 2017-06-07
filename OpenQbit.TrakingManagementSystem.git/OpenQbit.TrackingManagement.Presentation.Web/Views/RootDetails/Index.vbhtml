@ModelType IEnumerable(Of OpenQbit.TrakingManagement.Common.Models.RootDetail)
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
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RootID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Time)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RootID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.RootDetailID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.RootDetailID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.RootDetailID })
        </td>
    </tr>
Next

</table>
