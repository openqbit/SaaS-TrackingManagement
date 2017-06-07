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
    Public Class ToursController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: Tours
        Function Index() As ActionResult
            Return View(db.Tour.ToList())
        End Function

        ' GET: Tours/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tour As Tour = db.Tour.Find(id)
            If IsNothing(tour) Then
                Return HttpNotFound()
            End If
            Return View(tour)
        End Function

        ' GET: Tours/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tours/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TourID,TourType,Location,Root,Speed")> ByVal tour As Tour) As ActionResult
            If ModelState.IsValid Then
                db.Tour.Add(tour)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tour)
        End Function

        ' GET: Tours/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tour As Tour = db.Tour.Find(id)
            If IsNothing(tour) Then
                Return HttpNotFound()
            End If
            Return View(tour)
        End Function

        ' POST: Tours/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TourID,TourType,Location,Root,Speed")> ByVal tour As Tour) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tour).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tour)
        End Function

        ' GET: Tours/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tour As Tour = db.Tour.Find(id)
            If IsNothing(tour) Then
                Return HttpNotFound()
            End If
            Return View(tour)
        End Function

        ' POST: Tours/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tour As Tour = db.Tour.Find(id)
            db.Tour.Remove(tour)
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
