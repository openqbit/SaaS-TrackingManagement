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
    Public Class ResourcesController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: Resources
        Function Index() As ActionResult
            Return View(db.Resource.ToList())
        End Function

        ' GET: Resources/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim resource As Resource = db.Resource.Find(id)
            If IsNothing(resource) Then
                Return HttpNotFound()
            End If
            Return View(resource)
        End Function

        ' GET: Resources/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Resources/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ResourceID,UserID,GPSLocation")> ByVal resource As Resource) As ActionResult
            If ModelState.IsValid Then
                db.Resource.Add(resource)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(resource)
        End Function

        ' GET: Resources/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim resource As Resource = db.Resource.Find(id)
            If IsNothing(resource) Then
                Return HttpNotFound()
            End If
            Return View(resource)
        End Function

        ' POST: Resources/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ResourceID,UserID,GPSLocation")> ByVal resource As Resource) As ActionResult
            If ModelState.IsValid Then
                db.Entry(resource).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(resource)
        End Function

        ' GET: Resources/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim resource As Resource = db.Resource.Find(id)
            If IsNothing(resource) Then
                Return HttpNotFound()
            End If
            Return View(resource)
        End Function

        ' POST: Resources/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim resource As Resource = db.Resource.Find(id)
            db.Resource.Remove(resource)
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
