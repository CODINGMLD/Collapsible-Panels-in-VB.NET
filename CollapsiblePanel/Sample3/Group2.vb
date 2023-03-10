Imports CollapsiblePanel

NameSpace Sample3
    Public Class Group2
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
    Friend WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.SuspendLayout()
            '
            'collapseBox
            '
            Me.collapseBox.Name = "collapseBox"
            '
            'checkBox3
            '
            Me.checkBox3.Location = New System.Drawing.Point(16, 72)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.TabIndex = 8
            Me.checkBox3.Text = "checkBox3"
            '
            'checkBox2
            '
            Me.checkBox2.Location = New System.Drawing.Point(16, 48)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.TabIndex = 7
            Me.checkBox2.Text = "checkBox2"
            '
            'checkBox1
            '
            Me.checkBox1.Location = New System.Drawing.Point(16, 24)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.TabIndex = 6
            Me.checkBox1.Text = "checkBox1"
            '
            'Group2
            '
            Caption = "2nd Group"
            Me.Controls.Add(Me.checkBox3)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.checkBox1)
            Me.Name = "Group2"
            Me.Size = New System.Drawing.Size(144, 104)
            Me.Controls.SetChildIndex(Me.collapseBox, 0)
            Me.Controls.SetChildIndex(Me.checkBox1, 0)
            Me.Controls.SetChildIndex(Me.checkBox2, 0)
            Me.Controls.SetChildIndex(Me.checkBox3, 0)
            Me.ResumeLayout(False)

        End Sub

#End Region

    End Class
End NameSpace

