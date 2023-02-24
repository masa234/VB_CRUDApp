<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticleUpdate
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
        Me.btnArticleUpdate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtArticle = New System.Windows.Forms.TextBox()
        Me.lblArticle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnArticleUpdate
        '
        Me.btnArticleUpdate.Location = New System.Drawing.Point(517, 316)
        Me.btnArticleUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArticleUpdate.Name = "btnArticleUpdate"
        Me.btnArticleUpdate.Size = New System.Drawing.Size(131, 53)
        Me.btnArticleUpdate.TabIndex = 18
        Me.btnArticleUpdate.Text = "投稿"
        Me.btnArticleUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(369, 316)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtArticle
        '
        Me.txtArticle.Location = New System.Drawing.Point(155, 118)
        Me.txtArticle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtArticle.Multiline = True
        Me.txtArticle.Name = "txtArticle"
        Me.txtArticle.Size = New System.Drawing.Size(493, 177)
        Me.txtArticle.TabIndex = 16
        '
        'lblArticle
        '
        Me.lblArticle.AutoSize = True
        Me.lblArticle.Location = New System.Drawing.Point(152, 81)
        Me.lblArticle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArticle.Name = "lblArticle"
        Me.lblArticle.Size = New System.Drawing.Size(37, 15)
        Me.lblArticle.TabIndex = 15
        Me.lblArticle.Text = "記事"
        '
        'ArticleUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnArticleUpdate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtArticle)
        Me.Controls.Add(Me.lblArticle)
        Me.Name = "ArticleUpdate"
        Me.Text = "ArticleUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnArticleUpdate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtArticle As TextBox
    Friend WithEvents lblArticle As Label
End Class
