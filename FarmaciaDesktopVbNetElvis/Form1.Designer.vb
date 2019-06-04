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
        Me.PnlReports = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PnlCarregarRelatorios
        '
        Me.PnlCarregarRelatorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCarregarRelatorios.Location = New System.Drawing.Point(0, 499)
        Me.PnlCarregarRelatorios.Name = "PnlCarregarRelatorios"
        Me.PnlCarregarRelatorios.Size = New System.Drawing.Size(785, 62)
        Me.PnlCarregarRelatorios.TabIndex = 0
        '
        'PnlReports
        '
        Me.PnlReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlReports.Location = New System.Drawing.Point(0, 0)
        Me.PnlReports.Name = "PnlReports"
        Me.PnlReports.Size = New System.Drawing.Size(785, 502)
        Me.PnlReports.TabIndex = 1
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCarregarRelatorios As Panel
    Friend WithEvents PnlReports As Panel
End Class
