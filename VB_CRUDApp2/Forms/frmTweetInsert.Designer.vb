<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTweetInsert
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTweet = New System.Windows.Forms.TextBox()
        Me.lblTweet = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnTweetInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTweet
        '
        Me.txtTweet.Location = New System.Drawing.Point(160, 156)
        Me.txtTweet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTweet.Multiline = True
        Me.txtTweet.Name = "txtTweet"
        Me.txtTweet.Size = New System.Drawing.Size(493, 177)
        Me.txtTweet.TabIndex = 6
        '
        'lblTweet
        '
        Me.lblTweet.AutoSize = True
        Me.lblTweet.Location = New System.Drawing.Point(157, 119)
        Me.lblTweet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTweet.Name = "lblTweet"
        Me.lblTweet.Size = New System.Drawing.Size(52, 15)
        Me.lblTweet.TabIndex = 5
        Me.lblTweet.Text = "ツイート"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(381, 354)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnTweetInsert
        '
        Me.btnTweetInsert.Location = New System.Drawing.Point(527, 354)
        Me.btnTweetInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTweetInsert.Name = "btnTweetInsert"
        Me.btnTweetInsert.Size = New System.Drawing.Size(131, 53)
        Me.btnTweetInsert.TabIndex = 9
        Me.btnTweetInsert.Text = "投稿"
        Me.btnTweetInsert.UseVisualStyleBackColor = True
        '
        'frmTweetInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTweetInsert)
        Me.Controls.Add(Me.txtTweet)
        Me.Controls.Add(Me.lblTweet)
        Me.Name = "frmTweetInsert"
        Me.Text = "frmTweetInsert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTweet As TextBox
    Friend WithEvents lblTweet As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnTweetInsert As Button
End Class
