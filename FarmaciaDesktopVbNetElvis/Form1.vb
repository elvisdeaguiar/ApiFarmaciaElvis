Imports ApiFarmaciaElvis.Entidades.DTOs
Imports ApiFarmaciaElvis.Repositorios

Public Class FrmPrincipal
    Const NOME_CONNECTION_STRING As String = "FarmaciaElvis"

    Private ReadOnly ReportsService As ReportsService

    Private Function ObterConnectionString() As String
        Return System.Configuration.ConfigurationManager.ConnectionStrings(NOME_CONNECTION_STRING).ConnectionString
    End Function

    Private Sub AssociarComponentesVisuaisComDados()

    End Sub

    Private _VendasPorCategoria As List(Of VendaPorCategoriaDTO)
    Public Property VendasPorCategoria() As List(Of VendaPorCategoriaDTO)
        Get
            Return _VendasPorCategoria
        End Get
        Private Set(ByVal value As List(Of VendaPorCategoriaDTO))
            _VendasPorCategoria = value
        End Set
    End Property

    Private _VendasPorPeriodo As List(Of VendaPorPeriodoDTO)
    Public Property VendasPorPeriodo() As List(Of VendaPorPeriodoDTO)
        Get
            Return _VendasPorPeriodo
        End Get
        Private Set(ByVal value As List(Of VendaPorPeriodoDTO))
            _VendasPorPeriodo = value
        End Set
    End Property

    Private _VendasPorProduto As List(Of VendaPorProdutoDTO)
    Public Property VendasPorProduto() As List(Of VendaPorProdutoDTO)
        Get
            Return _VendasPorProduto
        End Get
        Private Set(ByVal value As List(Of VendaPorProdutoDTO))
            _VendasPorProduto = value
        End Set
    End Property

    Public Sub CarregarRelatorios()
        Dim Reports As ReportsDTO = Me.ReportsService.GetReports()

        If Not Reports Is Nothing Then
            Me.VendasPorCategoria = Reports.VendasPorCategoria
            Me.VendasPorPeriodo = Reports.VendasPorPeriodo
            Me.VendasPorProduto = Reports.VendasPorProduto
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim ConnectionString As String = ObterConnectionString()
        Me.ReportsService = New ReportsService(ConnectionString)

        AssociarComponentesVisuaisComDados()
        'CarregarRelatorios()
    End Sub

    Private Sub BtnRecarregar_Click(sender As Object, e As EventArgs) Handles BtnRecarregar.Click
        CarregarRelatorios()
    End Sub
End Class













