<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.optRock = New System.Windows.Forms.RadioButton()
        Me.optPaper = New System.Windows.Forms.RadioButton()
        Me.optScissors = New System.Windows.Forms.RadioButton()
        Me.picYou = New System.Windows.Forms.PictureBox()
        Me.picVS = New System.Windows.Forms.PictureBox()
        Me.picAi = New System.Windows.Forms.PictureBox()
        Me.picRPSai = New System.Windows.Forms.PictureBox()
        Me.picRPSyou = New System.Windows.Forms.PictureBox()
        Me.picBG = New System.Windows.Forms.PictureBox()
        Me.picPlayerScore = New System.Windows.Forms.PictureBox()
        Me.picScoreDash = New System.Windows.Forms.PictureBox()
        Me.picAIScore = New System.Windows.Forms.PictureBox()
        CType(Me.picYou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRPSai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRPSyou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScoreDash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAIScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(350, 310)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(75, 23)
        Me.btnShoot.TabIndex = 6
        Me.btnShoot.Text = "SHOOT!!!!!"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'optRock
        '
        Me.optRock.AutoSize = True
        Me.optRock.Location = New System.Drawing.Point(357, 339)
        Me.optRock.Name = "optRock"
        Me.optRock.Size = New System.Drawing.Size(60, 20)
        Me.optRock.TabIndex = 8
        Me.optRock.TabStop = True
        Me.optRock.Text = "Rock"
        Me.optRock.UseVisualStyleBackColor = True
        '
        'optPaper
        '
        Me.optPaper.AutoSize = True
        Me.optPaper.Location = New System.Drawing.Point(355, 365)
        Me.optPaper.Name = "optPaper"
        Me.optPaper.Size = New System.Drawing.Size(65, 20)
        Me.optPaper.TabIndex = 9
        Me.optPaper.TabStop = True
        Me.optPaper.Text = "Paper"
        Me.optPaper.UseVisualStyleBackColor = True
        '
        'optScissors
        '
        Me.optScissors.AutoSize = True
        Me.optScissors.Location = New System.Drawing.Point(350, 391)
        Me.optScissors.Name = "optScissors"
        Me.optScissors.Size = New System.Drawing.Size(80, 20)
        Me.optScissors.TabIndex = 10
        Me.optScissors.TabStop = True
        Me.optScissors.Text = "Scissors"
        Me.optScissors.UseVisualStyleBackColor = True
        '
        'picYou
        '
        Me.picYou.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.GD_you
        Me.picYou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picYou.Location = New System.Drawing.Point(182, 80)
        Me.picYou.Name = "picYou"
        Me.picYou.Size = New System.Drawing.Size(100, 50)
        Me.picYou.TabIndex = 5
        Me.picYou.TabStop = False
        '
        'picVS
        '
        Me.picVS.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.GD_vs
        Me.picVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVS.Location = New System.Drawing.Point(350, 80)
        Me.picVS.Name = "picVS"
        Me.picVS.Size = New System.Drawing.Size(100, 50)
        Me.picVS.TabIndex = 4
        Me.picVS.TabStop = False
        '
        'picAi
        '
        Me.picAi.BackgroundImage = CType(resources.GetObject("picAi.BackgroundImage"), System.Drawing.Image)
        Me.picAi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAi.Location = New System.Drawing.Point(532, 80)
        Me.picAi.Name = "picAi"
        Me.picAi.Size = New System.Drawing.Size(88, 50)
        Me.picAi.TabIndex = 7
        Me.picAi.TabStop = False
        '
        'picRPSai
        '
        Me.picRPSai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRPSai.Location = New System.Drawing.Point(471, 141)
        Me.picRPSai.Name = "picRPSai"
        Me.picRPSai.Size = New System.Drawing.Size(222, 126)
        Me.picRPSai.TabIndex = 1
        Me.picRPSai.TabStop = False
        '
        'picRPSyou
        '
        Me.picRPSyou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRPSyou.Location = New System.Drawing.Point(129, 141)
        Me.picRPSyou.Name = "picRPSyou"
        Me.picRPSyou.Size = New System.Drawing.Size(195, 126)
        Me.picRPSyou.TabIndex = 0
        Me.picRPSyou.TabStop = False
        '
        'picBG
        '
        Me.picBG.Image = Global.RockPaperScissors.My.Resources.Resources.IMG_4950
        Me.picBG.Location = New System.Drawing.Point(2, 2)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(800, 445)
        Me.picBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBG.TabIndex = 2
        Me.picBG.TabStop = False
        '
        'picPlayerScore
        '
        Me.picPlayerScore.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.GD_0
        Me.picPlayerScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerScore.Location = New System.Drawing.Point(197, 8)
        Me.picPlayerScore.Name = "picPlayerScore"
        Me.picPlayerScore.Size = New System.Drawing.Size(69, 66)
        Me.picPlayerScore.TabIndex = 11
        Me.picPlayerScore.TabStop = False
        '
        'picScoreDash
        '
        Me.picScoreDash.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.GD_Dash
        Me.picScoreDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picScoreDash.Location = New System.Drawing.Point(363, 27)
        Me.picScoreDash.Name = "picScoreDash"
        Me.picScoreDash.Size = New System.Drawing.Size(67, 21)
        Me.picScoreDash.TabIndex = 12
        Me.picScoreDash.TabStop = False
        '
        'picAIScore
        '
        Me.picAIScore.BackgroundImage = Global.RockPaperScissors.My.Resources.Resources.GD_0
        Me.picAIScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAIScore.Location = New System.Drawing.Point(532, 8)
        Me.picAIScore.Name = "picAIScore"
        Me.picAIScore.Size = New System.Drawing.Size(77, 66)
        Me.picAIScore.TabIndex = 13
        Me.picAIScore.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picAIScore)
        Me.Controls.Add(Me.picScoreDash)
        Me.Controls.Add(Me.picPlayerScore)
        Me.Controls.Add(Me.optScissors)
        Me.Controls.Add(Me.optPaper)
        Me.Controls.Add(Me.optRock)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.picYou)
        Me.Controls.Add(Me.picVS)
        Me.Controls.Add(Me.picAi)
        Me.Controls.Add(Me.picRPSai)
        Me.Controls.Add(Me.picRPSyou)
        Me.Controls.Add(Me.picBG)
        Me.Name = "Form3"
        Me.Text = "Easy"
        CType(Me.picYou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRPSai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRPSyou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScoreDash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAIScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRPSyou As PictureBox
    Friend WithEvents picRPSai As PictureBox
    Friend WithEvents picBG As PictureBox
    Friend WithEvents picAi As PictureBox
    Friend WithEvents picVS As PictureBox
    Friend WithEvents picYou As PictureBox
    Friend WithEvents btnShoot As Button
    Friend WithEvents optRock As RadioButton
    Friend WithEvents optPaper As RadioButton
    Friend WithEvents optScissors As RadioButton
    Friend WithEvents picPlayerScore As PictureBox
    Friend WithEvents picScoreDash As PictureBox
    Friend WithEvents picAIScore As PictureBox
End Class
