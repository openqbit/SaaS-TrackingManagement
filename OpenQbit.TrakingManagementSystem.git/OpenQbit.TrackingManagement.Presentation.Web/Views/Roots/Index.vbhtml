@ModelType IEnumerable(Of OpenQbit.TrakingManagement.Common.Models.Root)
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
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.RootID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.RootID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.RootID })
        </td>
    </tr>
Next

</table>
