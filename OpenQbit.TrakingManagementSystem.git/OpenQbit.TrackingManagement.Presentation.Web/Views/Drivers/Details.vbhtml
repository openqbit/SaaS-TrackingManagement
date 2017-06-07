﻿@ModelType OpenQbit.TrakingManagement.Common.Models.Driver
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Driver</h4>
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
            @Html.DisplayNameFor(Function(model) model.DriverID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DriverID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DriverName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DriverName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Dnic)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Dnic)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TourID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TourID)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ResourceID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
