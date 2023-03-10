Imports CollapsiblePanel
 
Namespace Sample3
    Public Class Form1
        Inherits System.Windows.Forms.Form

        ' collapsible panels
  	    Private Dim collapsePanel1  As CollapsePanel 
        ' group boxes
  	    Private Dim group11 As Group1 
	    Private Dim group21 As Group2 
	    Private Dim group31 As Group3 
	    Private Dim group41 As Group4 

        #Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(150, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(156, 23)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Vertical Panels"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CausesValidation = False
            Me.ClientSize = New System.Drawing.Size(456, 266)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

    #End Region

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            collapsePanel1              = New CollapsePanel()
            collapsePanel1.Location     = New Point(25, 30)
            collapsePanel1.Name         = "collapsePanel"
            collapsePanel1.Size         = New Size(425, 200)

            '
            'group11
            '
            group11             = New Group1()
            group11.Caption     = "Panel 1"
            group11.Size        = New System.Drawing.Size(400, 70)
            group11.Name        = "group11"
            group11.Minimize()
            collapsePanel1.Add(group11)
            '
            'group21
            '
            group21             = New Group2()
            group21.Caption     = "Panel 2"
            group21.Size        = New System.Drawing.Size(400, 104)
            group21.Name        = "group21"
            group21.Minimize()
            collapsePanel1.Add(group21)
            '
            'group31
            '
            group31             = New Group3()
            group31.Caption     = "Panel 3"
            group31.Size        = New System.Drawing.Size(400, 224)
            group31.Name        = "group31"
            group31.Minimize()            '
            collapsePanel1.Add(group31)
            '
            'group41
            '
            group41             = New Group4()
            group41.Caption     = "Panel 4"
            group41.Size        = New System.Drawing.Size(400, 192)
            group41.Name        = "group41"
            group41.Minimize()
            collapsePanel1.Add(group41)

            Controls.Add(collapsePanel1)

        End Sub
    End Class
End NameSpace
