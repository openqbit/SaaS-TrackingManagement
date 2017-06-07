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
    Public Class RootsController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: Roots
        Function Index() As ActionResult
            Return View(db.Root.ToList())
        End Function

        ' GET: Roots/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim root As Root = db.Root.Find(id)
            If IsNothing(root) Then
                Return HttpNotFound()
            End If
            Return View(root)
        End Function

        ' GET: Roots/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Roots/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="RootID")> ByVal root As Root) As ActionResult
            If ModelState.IsValid Then
                db.Root.Add(root)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(root)
        End Function

        ' GET: Roots/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim root As Root = db.Root.Find(id)
            If IsNothing(root) Then
                Return HttpNotFound()
            End If
            Return View(root)
        End Function

        ' POST: Roots/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="RootID")> ByVal root As Root) As ActionResult
            If ModelState.IsValid Then
                db.Entry(root).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(root)
        End Function

        ' GET: Roots/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim root As Root = db.Root.Find(id)
            If IsNothing(root) Then
                Return HttpNotFound()
            End If
            Return View(root)
        End Function

        ' POST: Roots/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim root As Root = db.Root.Find(id)
            db.Root.Remove(root)
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
