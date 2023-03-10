Imports CollapsiblePanel

Namespace Sample2
    Public Class Group1
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
        Friend WithEvents button1 As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'collapseBox
            '
            Me.collapseBox.Name = "collapseBox"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(48, 32)
            Me.button1.Name = "button1"
            Me.button1.TabIndex = 4
            Me.button1.Text = "button1"
            '
            'Group1
            '
            Me.Controls.Add(Me.button1)
            Me.Name = "Group1"
            Me.Size = New System.Drawing.Size(136, 64)
            Me.Controls.SetChildIndex(Me.collapseBox, 0)
            Me.Controls.SetChildIndex(Me.button1, 0)
            Me.ResumeLayout(False)

        End Sub

    #End Region

    End Class
End NameSpace
