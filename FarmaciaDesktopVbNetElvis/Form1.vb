Imports System.ComponentModel
Imports ApiFarmaciaElvis.Entidades.DTOs
Imports ApiFarmaciaElvis.Repositorios

Public Class FrmPrincipal
    Const NOME_CONNECTION_STRING As String = "FarmaciaElvis"

    Private ReadOnly ReportsService As ReportsService

    Private VendasPorCategoria As List(Of VendaPorCategoriaDTO)

    Private VendasPorPeriodo As List(Of VendaPorPeriodoDTO)

    Private VendasPorProduto As List(Of VendaPorProdutoDTO)

    Private Function ObterConnectionString() As String
        Return System.Configuration.ConfigurationManager.ConnectionStrings(NOME_CONNECTION_STRING).ConnectionString
    End Function

    Private Function ConvertListToBindingSource(Of T)(ByRef lista As IList(Of T)) As BindingSource
        If lista Is Nothing Then
            lista = New List(Of T)()
        End If

        Dim BindingList As BindingList(Of T) = New BindingList(Of T)(lista)
        Dim BindingSource As BindingSource = New BindingSource(BindingList, Nothing)

        Return BindingSource
    End Function


    Private Sub AssociarComponentesVisuaisComDados()
        Me.GridVendasPorCategoria.DataSource = ConvertListToBindingSource(Of VendaPorCategoriaDTO)(Me.VendasPorCategoria)
        Me.GridVendasPorPeriodo.DataSource = ConvertListToBindingSource(Of VendaPorPeriodoDTO)(Me.VendasPorPeriodo)
        Me.GridVendasPorProduto.DataSource = ConvertListToBindingSource(Of VendaPorProdutoDTO)(Me.VendasPorProduto)
    End Sub

    Public Sub CarregarRelatorios()
        Dim Reports As ReportsDTO = Me.ReportsService.GetReports()

        If Not Reports Is Nothing Then
            Me.VendasPorCategoria = Reports.VendasPorCategoria
            Me.VendasPorPeriodo = Reports.VendasPorPeriodo
            Me.VendasPorProduto = Reports.VendasPorProduto

            AssociarComponentesVisuaisComDados()
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim ConnectionString As String = ObterConnectionString()
        Me.ReportsService = New ReportsService(ConnectionString)

        CarregarRelatorios()
    End Sub

    Private Sub BtnRecarregar_Click(sender As Object, e As EventArgs) Handles BtnRecarregar.Click
        CarregarRelatorios()
    End Sub
End Class













