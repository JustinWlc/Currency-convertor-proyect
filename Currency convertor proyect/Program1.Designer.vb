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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.USD = New System.Windows.Forms.RadioButton()
        Me.EURO = New System.Windows.Forms.RadioButton()
        Me.YEN = New System.Windows.Forms.RadioButton()
        Me.UAH = New System.Windows.Forms.RadioButton()
        Me.Change = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(522, 150)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(192, 212)
        Me.lstTransactions.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(316, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 32)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(146, 383)
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
        'USD
        '
        Me.USD.AutoSize = True
        Me.USD.Location = New System.Drawing.Point(426, 60)
        Me.USD.Name = "USD"
        Me.USD.Size = New System.Drawing.Size(48, 17)
        Me.USD.TabIndex = 34
        Me.USD.TabStop = True
        Me.USD.Text = "USD"
        Me.USD.UseVisualStyleBackColor = True
        '
        'EURO
        '
        Me.EURO.AutoSize = True
        Me.EURO.Location = New System.Drawing.Point(426, 83)
        Me.EURO.Name = "EURO"
        Me.EURO.Size = New System.Drawing.Size(56, 17)
        Me.EURO.TabIndex = 35
        Me.EURO.TabStop = True
        Me.EURO.Text = "EURO"
        Me.EURO.UseVisualStyleBackColor = True
        '
        'YEN
        '
        Me.YEN.AutoSize = True
        Me.YEN.Location = New System.Drawing.Point(426, 105)
        Me.YEN.Name = "YEN"
        Me.YEN.Size = New System.Drawing.Size(47, 17)
        Me.YEN.TabIndex = 36
        Me.YEN.TabStop = True
        Me.YEN.Text = "YEN"
        Me.YEN.UseVisualStyleBackColor = True
        '
        'UAH
        '
        Me.UAH.AutoSize = True
        Me.UAH.Location = New System.Drawing.Point(426, 128)
        Me.UAH.Name = "UAH"
        Me.UAH.Size = New System.Drawing.Size(48, 17)
        Me.UAH.TabIndex = 37
        Me.UAH.TabStop = True
        Me.UAH.Text = "UAH"
        Me.UAH.UseVisualStyleBackColor = True
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
        'Program1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.UAH)
        Me.Controls.Add(Me.YEN)
        Me.Controls.Add(Me.EURO)
        Me.Controls.Add(Me.USD)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.btnSave)
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
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents USD As RadioButton
    Friend WithEvents EURO As RadioButton
    Friend WithEvents YEN As RadioButton
    Friend WithEvents UAH As RadioButton
    Friend WithEvents Change As Label
End Class
