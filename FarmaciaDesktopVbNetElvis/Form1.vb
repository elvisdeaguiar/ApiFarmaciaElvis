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

    Private Function ConverterCategoriaDeAbreviacaoParaExtenso(ByVal abreviacao As String) As String
        If abreviacao = "M" Then
            Return "Medicamento"
        ElseIf abreviacao = "NM" Then
            Return "Não-medicamento"
        ElseIf abreviacao = "NMA" Then
            Return "Não-medicamento alimento"
        Else
            Return abreviacao
        End If
    End Function

    Private Sub TraduzirVendaPorCategoria(ByRef vendaPorCategoria As VendaPorCategoriaDTO)
        If Not vendaPorCategoria Is Nothing Then
            vendaPorCategoria.Categoria = ConverterCategoriaDeAbreviacaoParaExtenso(vendaPorCategoria.Categoria)
        End If
    End Sub

    Private Sub TraduzirListaVendaPorCategoria(ByRef listaVendasPorCategoria As IList(Of VendaPorCategoriaDTO))
        If Not listaVendasPorCategoria Is Nothing Then
            For Each venda As VendaPorCategoriaDTO In listaVendasPorCategoria
                If Not venda Is Nothing Then
                    TraduzirVendaPorCategoria(venda)
                End If
            Next
        End If
    End Sub

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
            TraduzirListaVendaPorCategoria(Me.VendasPorCategoria)

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













