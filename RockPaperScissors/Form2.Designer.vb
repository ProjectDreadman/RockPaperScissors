<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picBtnEz = New System.Windows.Forms.PictureBox()
        Me.picBtnHard = New System.Windows.Forms.PictureBox()
        Me.picBtnInpossible = New System.Windows.Forms.PictureBox()
        Me.picInpossible = New System.Windows.Forms.PictureBox()
        Me.picHard = New System.Windows.Forms.PictureBox()
        Me.picEasy = New System.Windows.Forms.PictureBox()
        CType(Me.picBtnEz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBtnHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBtnInpossible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInpossible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBtnEz
        '
        Me.picBtnEz.BackColor = System.Drawing.Color.Transparent
        Me.picBtnEz.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.black_orb_removebg_preview
        Me.picBtnEz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBtnEz.Location = New System.Drawing.Point(74, 155)
        Me.picBtnEz.Name = "picBtnEz"
        Me.picBtnEz.Size = New System.Drawing.Size(161, 146)
        Me.picBtnEz.TabIndex = 0
        Me.picBtnEz.TabStop = False
        '
        'picBtnHard
        '
        Me.picBtnHard.BackColor = System.Drawing.Color.Transparent
        Me.picBtnHard.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.blue_orb_10_removebg_preview
        Me.picBtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBtnHard.Location = New System.Drawing.Point(307, 155)
        Me.picBtnHard.Name = "picBtnHard"
        Me.picBtnHard.Size = New System.Drawing.Size(161, 146)
        Me.picBtnHard.TabIndex = 1
        Me.picBtnHard.TabStop = False
        '
        'picBtnInpossible
        '
        Me.picBtnInpossible.BackColor = System.Drawing.Color.Transparent
        Me.picBtnInpossible.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.yellow_orb_10_removebg_preview
        Me.picBtnInpossible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBtnInpossible.Location = New System.Drawing.Point(533, 155)
        Me.picBtnInpossible.Name = "picBtnInpossible"
        Me.picBtnInpossible.Size = New System.Drawing.Size(161, 146)
        Me.picBtnInpossible.TabIndex = 2
        Me.picBtnInpossible.TabStop = False
        '
        'picInpossible
        '
        Me.picInpossible.BackColor = System.Drawing.Color.Transparent
        Me.picInpossible.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.gd_inpossible
        Me.picInpossible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picInpossible.Location = New System.Drawing.Point(533, 99)
        Me.picInpossible.Name = "picInpossible"
        Me.picInpossible.Size = New System.Drawing.Size(161, 50)
        Me.picInpossible.TabIndex = 3
        Me.picInpossible.TabStop = False
        '
        'picHard
        '
        Me.picHard.BackColor = System.Drawing.Color.Transparent
        Me.picHard.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.gd_hard
        Me.picHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHard.Location = New System.Drawing.Point(328, 99)
        Me.picHard.Name = "picHard"
        Me.picHard.Size = New System.Drawing.Size(120, 50)
        Me.picHard.TabIndex = 4
        Me.picHard.TabStop = False
        '
        'picEasy
        '
        Me.picEasy.BackColor = System.Drawing.Color.Transparent
        Me.picEasy.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.gd_easy
        Me.picEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEasy.Location = New System.Drawing.Point(95, 99)
        Me.picEasy.Name = "picEasy"
        Me.picEasy.Size = New System.Drawing.Size(121, 50)
        Me.picEasy.TabIndex = 5
        Me.picEasy.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.IMG_4950
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picEasy)
        Me.Controls.Add(Me.picHard)
        Me.Controls.Add(Me.picInpossible)
        Me.Controls.Add(Me.picBtnInpossible)
        Me.Controls.Add(Me.picBtnHard)
        Me.Controls.Add(Me.picBtnEz)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picBtnEz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBtnHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBtnInpossible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInpossible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBtnEz As PictureBox
    Friend WithEvents picBtnHard As PictureBox
    Friend WithEvents picBtnInpossible As PictureBox
    Friend WithEvents picInpossible As PictureBox
    Friend WithEvents picHard As PictureBox
    Friend WithEvents picEasy As PictureBox
End Class
