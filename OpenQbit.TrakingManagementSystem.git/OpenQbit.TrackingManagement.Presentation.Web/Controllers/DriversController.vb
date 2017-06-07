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
    Public Class DriversController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: Drivers
        Function Index() As ActionResult
            Return View(db.Resource.ToList())
        End Function

        ' GET: Drivers/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim driver As Driver = db.Resource.Find(id)
            If IsNothing(driver) Then
                Return HttpNotFound()
            End If
            Return View(driver)
        End Function

        ' GET: Drivers/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Drivers/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ResourceID,UserID,GPSLocation,DriverID,DriverName,Dnic,TourID")> ByVal driver As Driver) As ActionResult
            If ModelState.IsValid Then
                db.Resource.Add(driver)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(driver)
        End Function

        ' GET: Drivers/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim driver As Driver = db.Resource.Find(id)
            If IsNothing(driver) Then
                Return HttpNotFound()
            End If
            Return View(driver)
        End Function

        ' POST: Drivers/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ResourceID,UserID,GPSLocation,DriverID,DriverName,Dnic,TourID")> ByVal driver As Driver) As ActionResult
            If ModelState.IsValid Then
                db.Entry(driver).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(driver)
        End Function

        ' GET: Drivers/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim driver As Driver = db.Resource.Find(id)
            If IsNothing(driver) Then
                Return HttpNotFound()
            End If
            Return View(driver)
        End Function

        ' POST: Drivers/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim driver As Driver = db.Resource.Find(id)
            db.Resource.Remove(driver)
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
