Imports CollapsiblePanel

Namespace Sample2
    Public Class Form1
        Inherits System.Windows.Forms.Form
    	
		Private Dim group11 As Group1 
		Private Dim group21 As Group2 
		Private Dim group31 As Group3 
		Private Dim group41 As Group4 


        #Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            CollapsePanel1.Add(new Group1())
            CollapsePanel1.Add(new Group2())
            CollapsePanel1.Add(new Group3())
            CollapsePanel1.Add(new Group4())
            CollapsePanel1.Add(new Group1())

            CollapsePanel2.Add(new Group1())
            CollapsePanel2.Add(new Group2())
            CollapsePanel2.Add(new Group3())
            CollapsePanel2.Add(new Group4())

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
        Friend WithEvents collapseBox1 As CollapsiblePanel.CollapseBox
        Friend WithEvents collapsibleGroupBox1 As CollapsiblePanel.CollapseGroupBox
        Private WithEvents CollapsePanel1 As CollapsiblePanel.CollapsePanel
        Private WithEvents CollapsePanel2 As CollapsiblePanel.CollapsePanel
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.CollapsePanel1 = New CollapsiblePanel.CollapsePanel
            Me.CollapsePanel2 = New CollapsiblePanel.CollapsePanel
            Me.collapseBox1 = New CollapsiblePanel.CollapseBox
            Me.collapsibleGroupBox1 = New CollapsiblePanel.CollapseGroupBox
            Me.group11 = New Sample2.Group1
            Me.group21 = New Sample2.Group2
            Me.group31 = New Sample2.Group3
            Me.group41 = New Sample2.Group4
            Me.SuspendLayout()
            '
            'CollapsePanel1
            '
            Me.CollapsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CollapsePanel1.Location = New System.Drawing.Point(392, 24)
            Me.CollapsePanel1.Name = "CollapsePanel1"
            Me.CollapsePanel1.Size = New System.Drawing.Size(192, 184)
            Me.CollapsePanel1.TabIndex = 2
            '
            'CollapsePanel2
            '
            Me.CollapsePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CollapsePanel2.Location = New System.Drawing.Point(392, 224)
            Me.CollapsePanel2.Name = "CollapsePanel2"
            Me.CollapsePanel2.Size = New System.Drawing.Size(192, 184)
            Me.CollapsePanel2.TabIndex = 6
            '
            'collapseBox1
            '
            Me.collapseBox1.IsPlus = False
            Me.collapseBox1.Location = New System.Drawing.Point(32, 16)
            Me.collapseBox1.Name = "collapseBox1"
            Me.collapseBox1.Size = New System.Drawing.Size(24, 24)
            Me.collapseBox1.TabIndex = 2
            Me.collapseBox1.Text = "collapseBox1"
            '
            'collapsibleGroupBox1
            '
            Me.collapsibleGroupBox1.Caption = "A GroupBox"
            Me.collapsibleGroupBox1.Location = New System.Drawing.Point(24, 112)
            Me.collapsibleGroupBox1.Name = "collapsibleGroupBox1"
            Me.collapsibleGroupBox1.Size = New System.Drawing.Size(128, 72)
            Me.collapsibleGroupBox1.TabIndex = 3
            '
            'group11
            '
            Me.group11.Caption = Nothing
            Me.group11.Location = New System.Drawing.Point(24, 256)
            Me.group11.Name = "group11"
            Me.group11.Size = New System.Drawing.Size(136, 64)
            Me.group11.TabIndex = 4
            '
            'group21
            '
            Me.group21.Caption = "2nd Group"
            Me.group21.Location = New System.Drawing.Point(24, 344)
            Me.group21.Name = "group21"
            Me.group21.Size = New System.Drawing.Size(144, 104)
            Me.group21.TabIndex = 5
            '
            'group31
            '
            Me.group31.Caption = ""
            Me.group31.Location = New System.Drawing.Point(184, 16)
            Me.group31.Name = "group31"
            Me.group31.Size = New System.Drawing.Size(144, 224)
            Me.group31.TabIndex = 1
            '
            'group41
            '
            Me.group41.Caption = "Dual"
            Me.group41.Location = New System.Drawing.Point(184, 256)
            Me.group41.Name = "group41"
            Me.group41.Size = New System.Drawing.Size(160, 192)
            Me.group41.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(608, 454)
            Me.Controls.Add(Me.group41)
            Me.Controls.Add(Me.group31)
            Me.Controls.Add(Me.group21)
            Me.Controls.Add(Me.group11)
            Me.Controls.Add(Me.collapsibleGroupBox1)
            Me.Controls.Add(Me.collapseBox1)
            Me.Controls.Add(Me.CollapsePanel2)
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