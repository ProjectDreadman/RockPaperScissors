<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picBG = New System.Windows.Forms.PictureBox()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.ORBIT
        Me.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTitle.Location = New System.Drawing.Point(273, 12)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(242, 79)
        Me.picTitle.TabIndex = 2
        Me.picTitle.TabStop = False
        '
        'picPlay
        '
        Me.picPlay.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.gd_play_removebg_preview
        Me.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlay.Location = New System.Drawing.Point(273, 145)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(242, 188)
        Me.picPlay.TabIndex = 1
        Me.picPlay.TabStop = False
        '
        'picBG
        '
        Me.picBG.Image = Global.RockPaperScissors.My.Resources.Resources.IMG_4950
        Me.picBG.Location = New System.Drawing.Point(0, 0)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(802, 452)
        Me.picBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBG.TabIndex = 0
        Me.picBG.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picBG)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPlay As PictureBox
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents picBG As PictureBox
End Class
