<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Program2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Program2))
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chcUAH1 = New System.Windows.Forms.CheckBox()
        Me.chcUSD1 = New System.Windows.Forms.CheckBox()
        Me.chcEURO1 = New System.Windows.Forms.CheckBox()
        Me.chcYEN1 = New System.Windows.Forms.CheckBox()
        Me.Change = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(507, 125)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(192, 212)
        Me.lstTransactions.TabIndex = 47
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
        Me.label2.Size = New System.Drawing.Size(84, 29)
        Me.label2.TabIndex = 38
        Me.label2.Text = "To GBP"
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
        'chcUAH1
        '
        Me.chcUAH1.AutoSize = True
        Me.chcUAH1.Location = New System.Drawing.Point(145, 32)
        Me.chcUAH1.Name = "chcUAH1"
        Me.chcUAH1.Size = New System.Drawing.Size(49, 17)
        Me.chcUAH1.TabIndex = 59
        Me.chcUAH1.Text = "UAH"
        Me.chcUAH1.UseVisualStyleBackColor = True
        '
        'chcUSD1
        '
        Me.chcUSD1.AutoSize = True
        Me.chcUSD1.Location = New System.Drawing.Point(145, 55)
        Me.chcUSD1.Name = "chcUSD1"
        Me.chcUSD1.Size = New System.Drawing.Size(49, 17)
        Me.chcUSD1.TabIndex = 60
        Me.chcUSD1.Text = "USD"
        Me.chcUSD1.UseVisualStyleBackColor = True
        '
        'chcEURO1
        '
        Me.chcEURO1.AutoSize = True
        Me.chcEURO1.Location = New System.Drawing.Point(145, 78)
        Me.chcEURO1.Name = "chcEURO1"
        Me.chcEURO1.Size = New System.Drawing.Size(57, 17)
        Me.chcEURO1.TabIndex = 61
        Me.chcEURO1.Text = "EURO"
        Me.chcEURO1.UseVisualStyleBackColor = True
        '
        'chcYEN1
        '
        Me.chcYEN1.AutoSize = True
        Me.chcYEN1.Location = New System.Drawing.Point(145, 101)
        Me.chcYEN1.Name = "chcYEN1"
        Me.chcYEN1.Size = New System.Drawing.Size(48, 17)
        Me.chcYEN1.TabIndex = 62
        Me.chcYEN1.Text = "YEN"
        Me.chcYEN1.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Location = New System.Drawing.Point(256, 268)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(0, 13)
        Me.Change.TabIndex = 63
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(621, 368)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 32)
        Me.btnBack.TabIndex = 64
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Program2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.chcYEN1)
        Me.Controls.Add(Me.chcEURO1)
        Me.Controls.Add(Me.chcUSD1)
        Me.Controls.Add(Me.chcUAH1)
        Me.Controls.Add(Me.lstTransactions)
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
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chcUAH1 As CheckBox
    Friend WithEvents chcUSD1 As CheckBox
    Friend WithEvents chcEURO1 As CheckBox
    Friend WithEvents chcYEN1 As CheckBox
    Friend WithEvents Change As Label
    Friend WithEvents btnBack As Button
End Class
