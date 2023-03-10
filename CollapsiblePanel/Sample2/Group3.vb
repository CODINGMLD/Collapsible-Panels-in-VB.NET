Imports CollapsiblePanel

NameSpace Sample2
    Public Class Group3
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
    Friend WithEvents radioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.radioButton8 = New System.Windows.Forms.RadioButton
            Me.radioButton7 = New System.Windows.Forms.RadioButton
            Me.radioButton6 = New System.Windows.Forms.RadioButton
            Me.radioButton5 = New System.Windows.Forms.RadioButton
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.SuspendLayout()
            '
            'collapseBox
            '
            Me.collapseBox.Location = New System.Drawing.Point(12, 0)
            Me.collapseBox.Name = "collapseBox"
            '
            'radioButton8
            '
            Me.radioButton8.Location = New System.Drawing.Point(20, 192)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.TabIndex = 18
            Me.radioButton8.Text = "radioButton8"
            '
            'radioButton7
            '
            Me.radioButton7.Location = New System.Drawing.Point(20, 168)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.TabIndex = 17
            Me.radioButton7.Text = "radioButton7"
            '
            'radioButton6
            '
            Me.radioButton6.Location = New System.Drawing.Point(20, 144)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.TabIndex = 16
            Me.radioButton6.Text = "radioButton6"
            '
            'radioButton5
            '
            Me.radioButton5.Location = New System.Drawing.Point(20, 120)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.TabIndex = 15
            Me.radioButton5.Text = "radioButton5"
            '
            'radioButton4
            '
            Me.radioButton4.Location = New System.Drawing.Point(20, 96)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.TabIndex = 14
            Me.radioButton4.Text = "radioButton4"
            '
            'radioButton3
            '
            Me.radioButton3.Location = New System.Drawing.Point(20, 72)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.TabIndex = 13
            Me.radioButton3.Text = "radioButton3"
            '
            'radioButton2
            '
            Me.radioButton2.Location = New System.Drawing.Point(20, 48)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.TabIndex = 12
            Me.radioButton2.Text = "radioButton2"
            '
            'radioButton1
            '
            Me.radioButton1.Location = New System.Drawing.Point(20, 24)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.TabIndex = 11
            Me.radioButton1.Text = "radioButton1"
            '
            'Group3
            '
            Me.Caption = ""
            Me.Controls.Add(Me.radioButton8)
            Me.Controls.Add(Me.radioButton7)
            Me.Controls.Add(Me.radioButton6)
            Me.Controls.Add(Me.radioButton5)
            Me.Controls.Add(Me.radioButton4)
            Me.Controls.Add(Me.radioButton3)
            Me.Controls.Add(Me.radioButton2)
            Me.Controls.Add(Me.radioButton1)
            Me.Name = "Group3"
            Me.Size = New System.Drawing.Size(144, 224)
            Me.Controls.SetChildIndex(Me.collapseBox, 0)
            Me.Controls.SetChildIndex(Me.radioButton1, 0)
            Me.Controls.SetChildIndex(Me.radioButton2, 0)
            Me.Controls.SetChildIndex(Me.radioButton3, 0)
            Me.Controls.SetChildIndex(Me.radioButton4, 0)
            Me.Controls.SetChildIndex(Me.radioButton5, 0)
            Me.Controls.SetChildIndex(Me.radioButton6, 0)
            Me.Controls.SetChildIndex(Me.radioButton7, 0)
            Me.Controls.SetChildIndex(Me.radioButton8, 0)
            Me.ResumeLayout(False)

        End Sub

#End Region

    End Class
End NameSpace
