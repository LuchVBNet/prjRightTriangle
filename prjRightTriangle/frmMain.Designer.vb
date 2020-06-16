<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.lblSq1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picApp = New System.Windows.Forms.PictureBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDecimals = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpFormula = New System.Windows.Forms.GroupBox()
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.Font = New System.Drawing.Font("Book Antiqua", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.Location = New System.Drawing.Point(168, 36)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(310, 33)
        Me.lblApp.TabIndex = 6
        Me.lblApp.Text = "Pythagorean Theorem"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(31, 203)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 29)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(179, 203)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 29)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(327, 203)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(100, 29)
        Me.txtC.TabIndex = 4
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.Location = New System.Drawing.Point(142, 203)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(26, 27)
        Me.lblPlus.TabIndex = 10
        Me.lblPlus.Text = "+"
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquals.Location = New System.Drawing.Point(290, 205)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(26, 27)
        Me.lblEquals.TabIndex = 12
        Me.lblEquals.Text = "="
        '
        'lblSq1
        '
        Me.lblSq1.AutoSize = True
        Me.lblSq1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSq1.Location = New System.Drawing.Point(137, 181)
        Me.lblSq1.Name = "lblSq1"
        Me.lblSq1.Size = New System.Drawing.Size(21, 22)
        Me.lblSq1.TabIndex = 9
        Me.lblSq1.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "2"
        '
        'picApp
        '
        Me.picApp.Image = Global.prjRightTriangle.My.Resources.Resources._01141
        Me.picApp.Location = New System.Drawing.Point(8, 17)
        Me.picApp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picApp.Name = "picApp"
        Me.picApp.Size = New System.Drawing.Size(154, 123)
        Me.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApp.TabIndex = 0
        Me.picApp.TabStop = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(141, 273)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(109, 34)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(256, 273)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtDecimals
        '
        Me.txtDecimals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecimals.Location = New System.Drawing.Point(422, 107)
        Me.txtDecimals.Name = "txtDecimals"
        Me.txtDecimals.Size = New System.Drawing.Size(50, 29)
        Me.txtDecimals.TabIndex = 5
        Me.txtDecimals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Decimals:"
        '
        'grpFormula
        '
        Me.grpFormula.Location = New System.Drawing.Point(8, 171)
        Me.grpFormula.Name = "grpFormula"
        Me.grpFormula.Size = New System.Drawing.Size(464, 76)
        Me.grpFormula.TabIndex = 8
        Me.grpFormula.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 324)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDecimals)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSq1)
        Me.Controls.Add(Me.lblEquals)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.picApp)
        Me.Controls.Add(Me.grpFormula)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pythagorean Theorem"
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picApp As PictureBox
    Friend WithEvents lblApp As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents lblPlus As Label
    Friend WithEvents lblEquals As Label
    Friend WithEvents lblSq1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDecimals As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpFormula As GroupBox
End Class
