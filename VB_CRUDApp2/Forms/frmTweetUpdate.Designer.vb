<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTweetUpdate
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnTweetUpdate = New System.Windows.Forms.Button()
        Me.txtTweet = New System.Windows.Forms.TextBox()
        Me.lblTweet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(374, 316)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnTweetUpdate
        '
        Me.btnTweetUpdate.Location = New System.Drawing.Point(520, 316)
        Me.btnTweetUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTweetUpdate.Name = "btnTweetUpdate"
        Me.btnTweetUpdate.Size = New System.Drawing.Size(131, 53)
        Me.btnTweetUpdate.TabIndex = 13
        Me.btnTweetUpdate.Text = "更新"
        Me.btnTweetUpdate.UseVisualStyleBackColor = True
        '
        'txtTweet
        '
        Me.txtTweet.Location = New System.Drawing.Point(153, 126)
        Me.txtTweet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTweet.Multiline = True
        Me.txtTweet.Name = "txtTweet"
        Me.txtTweet.Size = New System.Drawing.Size(493, 177)
        Me.txtTweet.TabIndex = 12
        '
        'lblTweet
        '
        Me.lblTweet.AutoSize = True
        Me.lblTweet.Location = New System.Drawing.Point(150, 81)
        Me.lblTweet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTweet.Name = "lblTweet"
        Me.lblTweet.Size = New System.Drawing.Size(52, 15)
        Me.lblTweet.TabIndex = 11
        Me.lblTweet.Text = "ツイート"
        '
        'frmTweetUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTweetUpdate)
        Me.Controls.Add(Me.txtTweet)
        Me.Controls.Add(Me.lblTweet)
        Me.Name = "frmTweetUpdate"
        Me.Text = "frmTweetUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnTweetUpdate As Button
    Friend WithEvents txtTweet As TextBox
    Friend WithEvents lblTweet As Label
End Class
