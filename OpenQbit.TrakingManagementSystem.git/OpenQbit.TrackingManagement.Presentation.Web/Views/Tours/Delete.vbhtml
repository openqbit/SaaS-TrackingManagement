@ModelType OpenQbit.TrakingManagement.Common.Models.Tour
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
