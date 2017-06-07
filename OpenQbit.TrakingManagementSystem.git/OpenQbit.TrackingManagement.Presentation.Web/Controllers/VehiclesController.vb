Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports OpenQbit.TrakingManagement.Common.Models
Imports OpenQbit.TrakingManagement.DAL

Namespace Controllers
    Public Class VehiclesController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: Vehicles
        Function Index() As ActionResult
            Return View(db.Resource.ToList())
        End Function

        ' GET: Vehicles/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicle As Vehicle = db.Resource.Find(id)
            If IsNothing(vehicle) Then
                Return HttpNotFound()
            End If
            Return View(vehicle)
        End Function

        ' GET: Vehicles/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Vehicles/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ResourceID,UserID,GPSLocation,VehicleID,VehicleType,VehicleNO,TourNO")> ByVal vehicle As Vehicle) As ActionResult
            If ModelState.IsValid Then
                db.Resource.Add(vehicle)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehicle)
        End Function

        ' GET: Vehicles/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicle As Vehicle = db.Resource.Find(id)
            If IsNothing(vehicle) Then
                Return HttpNotFound()
            End If
            Return View(vehicle)
        End Function

        ' POST: Vehicles/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ResourceID,UserID,GPSLocation,VehicleID,VehicleType,VehicleNO,TourNO")> ByVal vehicle As Vehicle) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vehicle).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehicle)
        End Function

        ' GET: Vehicles/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehicle As Vehicle = db.Resource.Find(id)
            If IsNothing(vehicle) Then
                Return HttpNotFound()
            End If
            Return View(vehicle)
        End Function

        ' POST: Vehicles/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vehicle As Vehicle = db.Resource.Find(id)
            db.Resource.Remove(vehicle)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
