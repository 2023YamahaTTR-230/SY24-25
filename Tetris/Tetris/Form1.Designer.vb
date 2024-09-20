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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        Banana = New PictureBox()
        Banana2 = New PictureBox()
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Banana, ComponentModel.ISupportInitialize).BeginInit()
        CType(Banana2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(241, 31)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(262, 157)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' Banana
        ' 
        Banana.Image = My.Resources.Resources.Banana
        Banana.Location = New Point(296, 234)
        Banana.Name = "Banana"
        Banana.Size = New Size(225, 114)
        Banana.SizeMode = PictureBoxSizeMode.StretchImage
        Banana.TabIndex = 2
        Banana.TabStop = False
        Banana.Tag = "Banana"
        ' 
        ' Banana2
        ' 
        Banana2.Image = My.Resources.Resources.Banana
        Banana2.Location = New Point(551, 234)
        Banana2.Name = "Banana2"
        Banana2.Size = New Size(228, 113)
        Banana2.SizeMode = PictureBoxSizeMode.StretchImage
        Banana2.TabIndex = 3
        Banana2.TabStop = False
        Banana2.Tag = "Banana"
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(60, 234)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(198, 126)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 4
        Enemy.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(516, 261)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(198, 126)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 5
        Enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(Banana2)
        Controls.Add(Banana)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Banana, ComponentModel.ISupportInitialize).EndInit()
        CType(Banana2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Banana As PictureBox
    Friend WithEvents Banana2 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox

End Class
