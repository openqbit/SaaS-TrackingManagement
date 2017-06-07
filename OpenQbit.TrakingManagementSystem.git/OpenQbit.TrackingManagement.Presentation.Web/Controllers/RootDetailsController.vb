﻿Imports System
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
    Public Class RootDetailsController
        Inherits System.Web.Mvc.Controller

        Private db As New TrakingManagement.DAL.DBContext

        ' GET: RootDetails
        Function Index() As ActionResult
            Return View(db.RootDetail.ToList())
        End Function

        ' GET: RootDetails/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rootDetail As RootDetail = db.RootDetail.Find(id)
            If IsNothing(rootDetail) Then
                Return HttpNotFound()
            End If
            Return View(rootDetail)
        End Function

        ' GET: RootDetails/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: RootDetails/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="RootDetailID,City,Time,RootID")> ByVal rootDetail As RootDetail) As ActionResult
            If ModelState.IsValid Then
                db.RootDetail.Add(rootDetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rootDetail)
        End Function

        ' GET: RootDetails/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rootDetail As RootDetail = db.RootDetail.Find(id)
            If IsNothing(rootDetail) Then
                Return HttpNotFound()
            End If
            Return View(rootDetail)
        End Function

        ' POST: RootDetails/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="RootDetailID,City,Time,RootID")> ByVal rootDetail As RootDetail) As ActionResult
            If ModelState.IsValid Then
                db.Entry(rootDetail).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rootDetail)
        End Function

        ' GET: RootDetails/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rootDetail As RootDetail = db.RootDetail.Find(id)
            If IsNothing(rootDetail) Then
                Return HttpNotFound()
            End If
            Return View(rootDetail)
        End Function

        ' POST: RootDetails/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim rootDetail As RootDetail = db.RootDetail.Find(id)
            db.RootDetail.Remove(rootDetail)
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
