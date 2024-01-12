<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Program2))
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
        Me.UAH1 = New System.Windows.Forms.RadioButton()
        Me.YEN1 = New System.Windows.Forms.RadioButton()
        Me.EURO1 = New System.Windows.Forms.RadioButton()
        Me.USD1 = New System.Windows.Forms.RadioButton()
        Me.UAH2 = New System.Windows.Forms.RadioButton()
        Me.YEN2 = New System.Windows.Forms.RadioButton()
        Me.EURO2 = New System.Windows.Forms.RadioButton()
        Me.USD2 = New System.Windows.Forms.RadioButton()
        Me.GBP1 = New System.Windows.Forms.RadioButton()
        Me.GBP2 = New System.Windows.Forms.RadioButton()
        Me.Change = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(520, 149)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(192, 212)
        Me.lstTransactions.TabIndex = 47
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(295, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 32)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(111, 383)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 32)
        Me.btnReset.TabIndex = 44
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(621, 406)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(104, 32)
        Me.btnQuit.TabIndex = 43
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(37, 260)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(178, 37)
        Me.label4.TabIndex = 41
        Me.label4.Text = "Exchange Rate"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(263, 217)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(158, 20)
        Me.txtAmount.TabIndex = 40
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(69, 209)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(103, 37)
        Me.label3.TabIndex = 39
        Me.label3.Text = "Amount"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Himalaya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(360, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 29)
        Me.label2.TabIndex = 38
        Me.label2.Text = "To"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Himalaya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(38, 63)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(94, 29)
        Me.label1.TabIndex = 35
        Me.label1.Text = "Currency"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(645, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'UAH1
        '
        Me.UAH1.AutoSize = True
        Me.UAH1.Location = New System.Drawing.Point(412, 102)
        Me.UAH1.Name = "UAH1"
        Me.UAH1.Size = New System.Drawing.Size(48, 17)
        Me.UAH1.TabIndex = 51
        Me.UAH1.TabStop = True
        Me.UAH1.Text = "UAH"
        Me.UAH1.UseVisualStyleBackColor = True
        '
        'YEN1
        '
        Me.YEN1.AutoSize = True
        Me.YEN1.Location = New System.Drawing.Point(412, 79)
        Me.YEN1.Name = "YEN1"
        Me.YEN1.Size = New System.Drawing.Size(47, 17)
        Me.YEN1.TabIndex = 50
        Me.YEN1.TabStop = True
        Me.YEN1.Text = "YEN"
        Me.YEN1.UseVisualStyleBackColor = True
        '
        'EURO1
        '
        Me.EURO1.AutoSize = True
        Me.EURO1.Location = New System.Drawing.Point(412, 57)
        Me.EURO1.Name = "EURO1"
        Me.EURO1.Size = New System.Drawing.Size(56, 17)
        Me.EURO1.TabIndex = 49
        Me.EURO1.TabStop = True
        Me.EURO1.Text = "EURO"
        Me.EURO1.UseVisualStyleBackColor = True
        '
        'USD1
        '
        Me.USD1.AutoSize = True
        Me.USD1.Location = New System.Drawing.Point(412, 34)
        Me.USD1.Name = "USD1"
        Me.USD1.Size = New System.Drawing.Size(48, 17)
        Me.USD1.TabIndex = 48
        Me.USD1.TabStop = True
        Me.USD1.Text = "USD"
        Me.USD1.UseVisualStyleBackColor = True
        '
        'UAH2
        '
        Me.UAH2.AutoSize = True
        Me.UAH2.Location = New System.Drawing.Point(138, 102)
        Me.UAH2.Name = "UAH2"
        Me.UAH2.Size = New System.Drawing.Size(48, 17)
        Me.UAH2.TabIndex = 55
        Me.UAH2.TabStop = True
        Me.UAH2.Text = "UAH"
        Me.UAH2.UseVisualStyleBackColor = True
        '
        'YEN2
        '
        Me.YEN2.AutoSize = True
        Me.YEN2.Location = New System.Drawing.Point(138, 79)
        Me.YEN2.Name = "YEN2"
        Me.YEN2.Size = New System.Drawing.Size(47, 17)
        Me.YEN2.TabIndex = 54
        Me.YEN2.TabStop = True
        Me.YEN2.Text = "YEN"
        Me.YEN2.UseVisualStyleBackColor = True
        '
        'EURO2
        '
        Me.EURO2.AutoSize = True
        Me.EURO2.Location = New System.Drawing.Point(138, 57)
        Me.EURO2.Name = "EURO2"
        Me.EURO2.Size = New System.Drawing.Size(56, 17)
        Me.EURO2.TabIndex = 53
        Me.EURO2.TabStop = True
        Me.EURO2.Text = "EURO"
        Me.EURO2.UseVisualStyleBackColor = True
        '
        'USD2
        '
        Me.USD2.AutoSize = True
        Me.USD2.Location = New System.Drawing.Point(138, 34)
        Me.USD2.Name = "USD2"
        Me.USD2.Size = New System.Drawing.Size(48, 17)
        Me.USD2.TabIndex = 52
        Me.USD2.TabStop = True
        Me.USD2.Text = "USD"
        Me.USD2.UseVisualStyleBackColor = True
        '
        'GBP1
        '
        Me.GBP1.AutoSize = True
        Me.GBP1.Location = New System.Drawing.Point(412, 125)
        Me.GBP1.Name = "GBP1"
        Me.GBP1.Size = New System.Drawing.Size(47, 17)
        Me.GBP1.TabIndex = 56
        Me.GBP1.TabStop = True
        Me.GBP1.Text = "GBP"
        Me.GBP1.UseVisualStyleBackColor = True
        '
        'GBP2
        '
        Me.GBP2.AutoSize = True
        Me.GBP2.Location = New System.Drawing.Point(138, 125)
        Me.GBP2.Name = "GBP2"
        Me.GBP2.Size = New System.Drawing.Size(47, 17)
        Me.GBP2.TabIndex = 57
        Me.GBP2.TabStop = True
        Me.GBP2.Text = "GBP"
        Me.GBP2.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(256, 260)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(0, 37)
        Me.Change.TabIndex = 58
        '
        'Program2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.GBP2)
        Me.Controls.Add(Me.GBP1)
        Me.Controls.Add(Me.UAH2)
        Me.Controls.Add(Me.YEN2)
        Me.Controls.Add(Me.EURO2)
        Me.Controls.Add(Me.USD2)
        Me.Controls.Add(Me.UAH1)
        Me.Controls.Add(Me.YEN1)
        Me.Controls.Add(Me.EURO1)
        Me.Controls.Add(Me.USD1)
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
        Me.Name = "Program2"
        Me.Text = "Form2"
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
    Friend WithEvents UAH1 As RadioButton
    Friend WithEvents YEN1 As RadioButton
    Friend WithEvents EURO1 As RadioButton
    Friend WithEvents USD1 As RadioButton
    Friend WithEvents UAH2 As RadioButton
    Friend WithEvents YEN2 As RadioButton
    Friend WithEvents EURO2 As RadioButton
    Friend WithEvents USD2 As RadioButton
    Friend WithEvents GBP1 As RadioButton
    Friend WithEvents GBP2 As RadioButton
    Friend WithEvents Change As Label
End Class
