Imports System.Web.Mvc
Imports DisplayDetailInPopupWindow.Models

Namespace DisplayDetailInPopupWindow.Controllers

    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Function GridAction() As PartialViewResult
            Return PartialView("GridPartial", GetCustomers())
        End Function
    End Class
End Namespace
