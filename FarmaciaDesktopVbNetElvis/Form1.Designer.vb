<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlCarregarRelatorios = New System.Windows.Forms.Panel()
        Me.BtnRecarregar = New System.Windows.Forms.Button()
        Me.PnlReports = New System.Windows.Forms.Panel()
        Me.TabReports = New System.Windows.Forms.TabControl()
        Me.PagePeriodo = New System.Windows.Forms.TabPage()
        Me.GridVendasPorPeriodo = New System.Windows.Forms.DataGridView()
        Me.PageCategoria = New System.Windows.Forms.TabPage()
        Me.GridVendasPorCategoria = New System.Windows.Forms.DataGridView()
        Me.PageProduto = New System.Windows.Forms.TabPage()
        Me.GridVendasPorProduto = New System.Windows.Forms.DataGridView()
        Me.PnlCarregarRelatorios.SuspendLayout()
        Me.PnlReports.SuspendLayout()
        Me.TabReports.SuspendLayout()
        Me.PagePeriodo.SuspendLayout()
        CType(Me.GridVendasPorPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageCategoria.SuspendLayout()
        CType(Me.GridVendasPorCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageProduto.SuspendLayout()
        CType(Me.GridVendasPorProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCarregarRelatorios
        '
        Me.PnlCarregarRelatorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCarregarRelatorios.BackColor = System.Drawing.SystemColors.Control
        Me.PnlCarregarRelatorios.Controls.Add(Me.BtnRecarregar)
        Me.PnlCarregarRelatorios.Location = New System.Drawing.Point(0, 502)
        Me.PnlCarregarRelatorios.Name = "PnlCarregarRelatorios"
        Me.PnlCarregarRelatorios.Size = New System.Drawing.Size(785, 57)
        Me.PnlCarregarRelatorios.TabIndex = 0
        '
        'BtnRecarregar
        '
        Me.BtnRecarregar.Location = New System.Drawing.Point(342, 17)
        Me.BtnRecarregar.Name = "BtnRecarregar"
        Me.BtnRecarregar.Size = New System.Drawing.Size(125, 23)
        Me.BtnRecarregar.TabIndex = 0
        Me.BtnRecarregar.Text = "Recarregar"
        Me.BtnRecarregar.UseVisualStyleBackColor = True
        '
        'PnlReports
        '
        Me.PnlReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlReports.BackColor = System.Drawing.SystemColors.Control
        Me.PnlReports.Controls.Add(Me.TabReports)
        Me.PnlReports.Location = New System.Drawing.Point(0, 1)
        Me.PnlReports.Name = "PnlReports"
        Me.PnlReports.Size = New System.Drawing.Size(785, 502)
        Me.PnlReports.TabIndex = 1
        '
        'TabReports
        '
        Me.TabReports.Controls.Add(Me.PagePeriodo)
        Me.TabReports.Controls.Add(Me.PageCategoria)
        Me.TabReports.Controls.Add(Me.PageProduto)
        Me.TabReports.Location = New System.Drawing.Point(43, 28)
        Me.TabReports.Name = "TabReports"
        Me.TabReports.SelectedIndex = 0
        Me.TabReports.Size = New System.Drawing.Size(699, 439)
        Me.TabReports.TabIndex = 0
        '
        'PagePeriodo
        '
        Me.PagePeriodo.Controls.Add(Me.GridVendasPorPeriodo)
        Me.PagePeriodo.Location = New System.Drawing.Point(4, 22)
        Me.PagePeriodo.Name = "PagePeriodo"
        Me.PagePeriodo.Padding = New System.Windows.Forms.Padding(3)
        Me.PagePeriodo.Size = New System.Drawing.Size(691, 413)
        Me.PagePeriodo.TabIndex = 0
        Me.PagePeriodo.Text = "Vendas por Período"
        Me.PagePeriodo.UseVisualStyleBackColor = True
        '
        'GridVendasPorPeriodo
        '
        Me.GridVendasPorPeriodo.AllowUserToAddRows = False
        Me.GridVendasPorPeriodo.AllowUserToDeleteRows = False
        Me.GridVendasPorPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVendasPorPeriodo.Location = New System.Drawing.Point(159, 15)
        Me.GridVendasPorPeriodo.Name = "GridVendasPorPeriodo"
        Me.GridVendasPorPeriodo.ReadOnly = True
        Me.GridVendasPorPeriodo.Size = New System.Drawing.Size(349, 376)
        Me.GridVendasPorPeriodo.TabIndex = 0
        '
        'PageCategoria
        '
        Me.PageCategoria.Controls.Add(Me.GridVendasPorCategoria)
        Me.PageCategoria.Location = New System.Drawing.Point(4, 22)
        Me.PageCategoria.Name = "PageCategoria"
        Me.PageCategoria.Padding = New System.Windows.Forms.Padding(3)
        Me.PageCategoria.Size = New System.Drawing.Size(691, 413)
        Me.PageCategoria.TabIndex = 1
        Me.PageCategoria.Text = "Vendas por Categoria"
        Me.PageCategoria.UseVisualStyleBackColor = True
        '
        'GridVendasPorCategoria
        '
        Me.GridVendasPorCategoria.AllowUserToAddRows = False
        Me.GridVendasPorCategoria.AllowUserToDeleteRows = False
        Me.GridVendasPorCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVendasPorCategoria.Location = New System.Drawing.Point(192, 18)
        Me.GridVendasPorCategoria.Name = "GridVendasPorCategoria"
        Me.GridVendasPorCategoria.ReadOnly = True
        Me.GridVendasPorCategoria.Size = New System.Drawing.Size(306, 376)
        Me.GridVendasPorCategoria.TabIndex = 1
        '
        'PageProduto
        '
        Me.PageProduto.Controls.Add(Me.GridVendasPorProduto)
        Me.PageProduto.Location = New System.Drawing.Point(4, 22)
        Me.PageProduto.Name = "PageProduto"
        Me.PageProduto.Size = New System.Drawing.Size(691, 413)
        Me.PageProduto.TabIndex = 2
        Me.PageProduto.Text = "Vendas por Produto"
        Me.PageProduto.UseVisualStyleBackColor = True
        '
        'GridVendasPorProduto
        '
        Me.GridVendasPorProduto.AllowUserToAddRows = False
        Me.GridVendasPorProduto.AllowUserToDeleteRows = False
        Me.GridVendasPorProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVendasPorProduto.Location = New System.Drawing.Point(192, 18)
        Me.GridVendasPorProduto.Name = "GridVendasPorProduto"
        Me.GridVendasPorProduto.ReadOnly = True
        Me.GridVendasPorProduto.Size = New System.Drawing.Size(306, 376)
        Me.GridVendasPorProduto.TabIndex = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PnlReports)
        Me.Controls.Add(Me.PnlCarregarRelatorios)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farmácia VB.NET Elvis"
        Me.PnlCarregarRelatorios.ResumeLayout(False)
        Me.PnlReports.ResumeLayout(False)
        Me.TabReports.ResumeLayout(False)
        Me.PagePeriodo.ResumeLayout(False)
        CType(Me.GridVendasPorPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageCategoria.ResumeLayout(False)
        CType(Me.GridVendasPorCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageProduto.ResumeLayout(False)
        CType(Me.GridVendasPorProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCarregarRelatorios As Panel
    Friend WithEvents PnlReports As Panel
    Friend WithEvents BtnRecarregar As Button
    Friend WithEvents TabReports As TabControl
    Friend WithEvents PagePeriodo As TabPage
    Friend WithEvents GridVendasPorPeriodo As DataGridView
    Friend WithEvents PageCategoria As TabPage
    Friend WithEvents GridVendasPorCategoria As DataGridView
    Friend WithEvents PageProduto As TabPage
    Friend WithEvents GridVendasPorProduto As DataGridView
End Class
