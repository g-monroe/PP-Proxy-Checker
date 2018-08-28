Imports System.Threading
Imports Proxy_Checker.ProxyCheckerProvider
Public Class frmMain
    Private Async Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Using Proxy = New ProxyCheckerProvider
            Try
                Dim cts As New CancellationTokenSource()
                cts.CancelAfter(Int(tbTimeout.Text))

                Dim response = Await Proxy.ProxyCheck(tbIP.Text, tbPort.Text, cts.Token)
                lblProxy.Text = response.ToString
            Catch ex As OperationCanceledException
                lblProxy.Text = "Time Out"
            End Try
        End Using
    End Sub

End Class
