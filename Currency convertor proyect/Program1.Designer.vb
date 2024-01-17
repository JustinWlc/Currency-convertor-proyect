<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Program1))
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Change = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chcUSD = New System.Windows.Forms.CheckBox()
        Me.chcYEN = New System.Windows.Forms.CheckBox()
        Me.chcEURO = New System.Windows.Forms.CheckBox()
        Me.chcUAH = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(526, 128)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(192, 212)
        Me.lstTransactions.TabIndex = 33
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(21, 406)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 32)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(656, 406)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(104, 32)
        Me.btnQuit.TabIndex = 29
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(52, 260)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(178, 37)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Exchange Rate"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(289, 217)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(158, 20)
        Me.txtAmount.TabIndex = 26
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(88, 209)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(103, 37)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Amount"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Himalaya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(383, 101)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 29)
        Me.label2.TabIndex = 24
        Me.label2.Text = "To"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Himalaya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(102, 101)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(141, 29)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Currency GBP"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(638, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(282, 260)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(0, 37)
        Me.Change.TabIndex = 38
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(656, 368)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 32)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'chcUSD
        '
        Me.chcUSD.AutoSize = True
        Me.chcUSD.Location = New System.Drawing.Point(431, 58)
        Me.chcUSD.Name = "chcUSD"
        Me.chcUSD.Size = New System.Drawing.Size(49, 17)
        Me.chcUSD.TabIndex = 42
        Me.chcUSD.Text = "USD"
        Me.chcUSD.UseVisualStyleBackColor = True
        '
        'chcYEN
        '
        Me.chcYEN.AutoSize = True
        Me.chcYEN.Location = New System.Drawing.Point(431, 104)
        Me.chcYEN.Name = "chcYEN"
        Me.chcYEN.Size = New System.Drawing.Size(48, 17)
        Me.chcYEN.TabIndex = 43
        Me.chcYEN.Text = "YEN"
        Me.chcYEN.UseVisualStyleBackColor = True
        '
        'chcEURO
        '
        Me.chcEURO.AutoSize = True
        Me.chcEURO.Location = New System.Drawing.Point(431, 81)
        Me.chcEURO.Name = "chcEURO"
        Me.chcEURO.Size = New System.Drawing.Size(57, 17)
        Me.chcEURO.TabIndex = 44
        Me.chcEURO.Text = "EURO"
        Me.chcEURO.UseVisualStyleBackColor = True
        '
        'chcUAH
        '
        Me.chcUAH.AutoSize = True
        Me.chcUAH.Location = New System.Drawing.Point(431, 128)
        Me.chcUAH.Name = "chcUAH"
        Me.chcUAH.Size = New System.Drawing.Size(49, 17)
        Me.chcUAH.TabIndex = 45
        Me.chcUAH.Text = "UAH"
        Me.chcUAH.UseVisualStyleBackColor = True
        '
        'Program1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chcUAH)
        Me.Controls.Add(Me.chcEURO)
        Me.Controls.Add(Me.chcYEN)
        Me.Controls.Add(Me.chcUSD)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Program1"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTransactions As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Change As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents chcUSD As CheckBox
    Friend WithEvents chcYEN As CheckBox
    Friend WithEvents chcEURO As CheckBox
    Friend WithEvents chcUAH As CheckBox
End Class
