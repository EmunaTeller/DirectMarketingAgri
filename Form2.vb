'Imports System.Data
'Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration

Public Class Form2
    Dim dtOrderCodes As DataTable
    Dim rptDocument As New ReportDocument
    Dim sReportPath As String

    Public Sub New(OrdersCodes As DataTable)
        InitializeComponent()
        dtOrderCodes = OrdersCodes
        sReportPath = ConfigurationManager.AppSettings("ReportPath").ToString
        rptDocument.Load(sReportPath)
        Dim sConString As String = ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim myParameterFields As New ParameterFields
        Dim myParameterField As New ParameterField
        Dim myDiscreteValue As ParameterDiscreteValue
        Dim crParam1 As ParameterFieldDefinition = rptDocument.DataDefinition.ParameterFields.Item(0)

        myParameterField.ParameterFieldName = "OrderCode"

        For Each row In dtOrderCodes.Rows()
            myDiscreteValue = New ParameterDiscreteValue
            myDiscreteValue.Value = row("OrderCode")
            myParameterField.CurrentValues.Add(myDiscreteValue)

        Next

        myParameterFields.Add(myParameterField)

        CrystalReportViewer1.ParameterFieldInfo = myParameterFields
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.ReportSource = rptDocument
        Me.CenterToScreen()
    End Sub
End Class