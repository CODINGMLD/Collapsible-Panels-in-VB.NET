Imports CollapsiblePanel

Namespace Sample1
    Public Class Form1
        Inherits System.Windows.Forms.Form

        #Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            CollapsePanel1.Add(new UserControl1())
            
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
        Friend WithEvents CollapsePanel1 As CollapsiblePanel.CollapsePanel
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.CollapsePanel1 = New CollapsiblePanel.CollapsePanel
            Me.SuspendLayout()
            '
            'CollapsePanel1
            '
            Me.CollapsePanel1.Location = New System.Drawing.Point(8, 8)
            Me.CollapsePanel1.Name = "CollapsePanel1"
            Me.CollapsePanel1.Size = New System.Drawing.Size(200, 192)
            Me.CollapsePanel1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(218, 208)
            Me.Controls.Add(Me.CollapsePanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

    #End Region

    End Class
End NameSpace

