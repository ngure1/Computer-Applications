<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        Label4 = New Label()
        BoldItalicBox = New CheckBox()
        BoldBox = New CheckBox()
        ItalicBox = New CheckBox()
        PictureBox = New PictureBox()
        Panel4 = New Panel()
        TextGreen = New RadioButton()
        TextBlue = New RadioButton()
        TextRed = New RadioButton()
        Label2 = New Label()
        Tahoma = New RadioButton()
        Garamond = New RadioButton()
        Label3 = New Label()
        Magento = New RadioButton()
        Panel2 = New Panel()
        Panel1 = New Panel()
        TextBox = New TextBox()
        Panel3 = New Panel()
        Label1 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(53, 710)
        Button1.Name = "Button1"
        Button1.Size = New Size(192, 57)
        Button1.TabIndex = 21
        Button1.Text = "Load Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(858, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 25)
        Label4.TabIndex = 19
        Label4.Text = "Font Color"
        ' 
        ' BoldItalicBox
        ' 
        BoldItalicBox.AutoSize = True
        BoldItalicBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        BoldItalicBox.Location = New Point(21, 281)
        BoldItalicBox.Name = "BoldItalicBox"
        BoldItalicBox.Size = New Size(126, 29)
        BoldItalicBox.TabIndex = 2
        BoldItalicBox.Text = "Bold Italic"
        BoldItalicBox.UseVisualStyleBackColor = True
        ' 
        ' BoldBox
        ' 
        BoldBox.AutoSize = True
        BoldBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BoldBox.Location = New Point(21, 150)
        BoldBox.Name = "BoldBox"
        BoldBox.Size = New Size(77, 29)
        BoldBox.TabIndex = 1
        BoldBox.Text = "Bold"
        BoldBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicBox
        ' 
        ItalicBox.AutoSize = True
        ItalicBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        ItalicBox.Location = New Point(21, 57)
        ItalicBox.Name = "ItalicBox"
        ItalicBox.Size = New Size(77, 29)
        ItalicBox.TabIndex = 0
        ItalicBox.Text = "Italic"
        ItalicBox.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.Location = New Point(53, 306)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(339, 336)
        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox.TabIndex = 20
        PictureBox.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(TextGreen)
        Panel4.Controls.Add(TextBlue)
        Panel4.Controls.Add(TextRed)
        Panel4.Location = New Point(830, 306)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 398)
        Panel4.TabIndex = 18
        ' 
        ' TextGreen
        ' 
        TextGreen.AutoSize = True
        TextGreen.FlatAppearance.BorderColor = Color.Black
        TextGreen.Location = New Point(52, 56)
        TextGreen.Name = "TextGreen"
        TextGreen.Size = New Size(83, 29)
        TextGreen.TabIndex = 9
        TextGreen.TabStop = True
        TextGreen.Text = "Green"
        TextGreen.UseVisualStyleBackColor = True
        ' 
        ' TextBlue
        ' 
        TextBlue.AutoSize = True
        TextBlue.FlatAppearance.BorderColor = Color.Black
        TextBlue.Location = New Point(52, 150)
        TextBlue.Name = "TextBlue"
        TextBlue.Size = New Size(70, 29)
        TextBlue.TabIndex = 8
        TextBlue.TabStop = True
        TextBlue.Text = "Blue"
        TextBlue.UseVisualStyleBackColor = True
        ' 
        ' TextRed
        ' 
        TextRed.AutoSize = True
        TextRed.FlatAppearance.BorderColor = Color.Black
        TextRed.Location = New Point(52, 280)
        TextRed.Name = "TextRed"
        TextRed.Size = New Size(67, 29)
        TextRed.TabIndex = 7
        TextRed.TabStop = True
        TextRed.Text = "Red"
        TextRed.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(443, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 25)
        Label2.TabIndex = 12
        Label2.Text = "Font"
        ' 
        ' Tahoma
        ' 
        Tahoma.AutoSize = True
        Tahoma.Location = New Point(580, 29)
        Tahoma.Name = "Tahoma"
        Tahoma.Size = New Size(99, 29)
        Tahoma.TabIndex = 8
        Tahoma.TabStop = True
        Tahoma.Text = "Tahoma"
        Tahoma.UseVisualStyleBackColor = True
        ' 
        ' Garamond
        ' 
        Garamond.AutoSize = True
        Garamond.FlatAppearance.BorderColor = Color.Black
        Garamond.Location = New Point(22, 29)
        Garamond.Name = "Garamond"
        Garamond.Size = New Size(121, 29)
        Garamond.TabIndex = 6
        Garamond.TabStop = True
        Garamond.Text = "Garamond"
        Garamond.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(518, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 25)
        Label3.TabIndex = 17
        Label3.Text = "Font Style"
        ' 
        ' Magento
        ' 
        Magento.AutoSize = True
        Magento.Location = New Point(275, 29)
        Magento.Name = "Magento"
        Magento.Size = New Size(109, 29)
        Magento.TabIndex = 7
        Magento.TabStop = True
        Magento.Text = "Magento"
        Magento.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Magento)
        Panel2.Controls.Add(Tahoma)
        Panel2.Controls.Add(Garamond)
        Panel2.Location = New Point(409, 133)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 96)
        Panel2.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TextBox)
        Panel1.Location = New Point(65, 115)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(265, 114)
        Panel1.TabIndex = 13
        ' 
        ' TextBox
        ' 
        TextBox.BackColor = SystemColors.Window
        TextBox.BorderStyle = BorderStyle.FixedSingle
        TextBox.ForeColor = SystemColors.WindowText
        TextBox.Location = New Point(18, 47)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(215, 31)
        TextBox.TabIndex = 2
        TextBox.Text = "Sample Text"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(BoldItalicBox)
        Panel3.Controls.Add(BoldBox)
        Panel3.Controls.Add(ItalicBox)
        Panel3.Location = New Point(496, 306)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(292, 398)
        Panel3.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, -35)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 15
        Label1.Text = "Display Test"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 25)
        Label5.TabIndex = 22
        Label5.Text = "Display text"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(830, 718)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 49)
        Button2.TabIndex = 23
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 817)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(PictureBox)
        Controls.Add(Panel4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BoldItalicBox As CheckBox
    Friend WithEvents BoldBox As CheckBox
    Friend WithEvents ItalicBox As CheckBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents Garamond As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Magento As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextGreen As RadioButton
    Friend WithEvents TextBlue As RadioButton
    Friend WithEvents TextRed As RadioButton
End Class
