Imports CollapsiblePanel

NameSpace Sample2
    Public Class Group4
        Inherits CollapseGroupBox

    #Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'collapseBox
            '
            Me.collapseBox.Name = "collapseBox"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.radioButton4)
            Me.groupBox2.Controls.Add(Me.radioButton3)
            Me.groupBox2.Location = New System.Drawing.Point(16, 104)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(136, 72)
            Me.groupBox2.TabIndex = 6
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "groupBox2"
            '
            'radioButton4
            '
            Me.radioButton4.Location = New System.Drawing.Point(16, 40)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.TabIndex = 1
            Me.radioButton4.Text = "radioButton4"
            '
            'radioButton3
            '
            Me.radioButton3.Location = New System.Drawing.Point(16, 16)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.TabIndex = 0
            Me.radioButton3.Text = "radioButton3"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Location = New System.Drawing.Point(16, 24)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(136, 72)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "groupBox1"
            '
            'radioButton2
            '
            Me.radioButton2.Location = New System.Drawing.Point(16, 40)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "radioButton2"
            '
            'radioButton1
            '
            Me.radioButton1.Location = New System.Drawing.Point(16, 16)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.Text = "radioButton1"
            '
            'Group4
            '
            Me.Caption = "Dual"
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "Group4"
            Me.Size = New System.Drawing.Size(160, 192)
            Me.Controls.SetChildIndex(Me.collapseBox, 0)
            Me.Controls.SetChildIndex(Me.groupBox1, 0)
            Me.Controls.SetChildIndex(Me.groupBox2, 0)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

    End Class
End NameSpace
