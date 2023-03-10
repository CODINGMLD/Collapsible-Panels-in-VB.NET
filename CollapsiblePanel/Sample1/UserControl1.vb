Imports CollapsiblePanel

Namespace Sample1
    Public Class UserControl1
        Inherits CollapseGroupBox

        #Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

        End Sub

        'UserControl overrides dispose to clean up the component list.
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
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Button1 = New System.Windows.Forms.Button
            Me.Label1 = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'm_CollapseBox
            '
            Me.collapseBox.Name = "m_CollapseBox"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(40, 104)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(32, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Label1"
            '
            'UserControl1
            '
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button1)
            Me.Name = "UserControl1"
        '   Me.Size = New System.Drawing.Size(160, 150)
            Me.Controls.SetChildIndex(Me.Button1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.collapseBox, 0)
            Me.ResumeLayout(False)

        End Sub

    #End Region

    End Class
End Namespace

