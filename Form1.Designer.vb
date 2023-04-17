<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnCompute = New Button()
        txtenglish = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtfilipino = New TextBox()
        Label3 = New Label()
        txtscience = New TextBox()
        Label4 = New Label()
        txtmath = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        statustext = New Label()
        gradetext = New Label()
        remarkstext = New Label()
        SuspendLayout()
        ' 
        ' BtnCompute
        ' 
        BtnCompute.Location = New Point(261, 186)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(75, 23)
        BtnCompute.TabIndex = 4
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' txtenglish
        ' 
        txtenglish.Location = New Point(261, 143)
        txtenglish.Name = "txtenglish"
        txtenglish.Size = New Size(100, 23)
        txtenglish.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 2
        Label1.Text = "English"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(209, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 4
        Label2.Text = "Filipino"
        ' 
        ' txtfilipino
        ' 
        txtfilipino.Location = New Point(261, 114)
        txtfilipino.Name = "txtfilipino"
        txtfilipino.Size = New Size(100, 23)
        txtfilipino.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(208, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 6
        Label3.Text = "Science"
        ' 
        ' txtscience
        ' 
        txtscience.Location = New Point(261, 85)
        txtscience.Name = "txtscience"
        txtscience.Size = New Size(100, 23)
        txtscience.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(220, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 8
        Label4.Text = "Math"
        ' 
        ' txtmath
        ' 
        txtmath.Location = New Point(261, 56)
        txtmath.Name = "txtmath"
        txtmath.Size = New Size(100, 23)
        txtmath.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 12
        Label5.Text = "Remarks :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(70, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 11
        Label6.Text = "Status :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(66, 231)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 10
        Label7.Text = "Grades :"
        ' 
        ' statustext
        ' 
        statustext.AutoSize = True
        statustext.Location = New Point(115, 205)
        statustext.Name = "statustext"
        statustext.Size = New Size(29, 15)
        statustext.TabIndex = 15
        statustext.Text = "N/A"
        ' 
        ' gradetext
        ' 
        gradetext.AutoSize = True
        gradetext.Location = New Point(115, 231)
        gradetext.Name = "gradetext"
        gradetext.Size = New Size(29, 15)
        gradetext.TabIndex = 14
        gradetext.Text = "N/A"
        ' 
        ' remarkstext
        ' 
        remarkstext.AutoSize = True
        remarkstext.Location = New Point(115, 258)
        remarkstext.Name = "remarkstext"
        remarkstext.Size = New Size(29, 15)
        remarkstext.TabIndex = 13
        remarkstext.Text = "N/A"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 298)
        Controls.Add(statustext)
        Controls.Add(gradetext)
        Controls.Add(remarkstext)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(txtmath)
        Controls.Add(Label3)
        Controls.Add(txtscience)
        Controls.Add(Label2)
        Controls.Add(txtfilipino)
        Controls.Add(Label1)
        Controls.Add(txtenglish)
        Controls.Add(BtnCompute)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCompute As Button
    Friend WithEvents txtenglish As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfilipino As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtscience As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents statustext As Label
    Friend WithEvents gradetext As Label
    Friend WithEvents remarkstext As Label
End Class
