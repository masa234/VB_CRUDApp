<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticleInsert
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
        Me.txtArticle = New System.Windows.Forms.TextBox()
        Me.lblArticle = New System.Windows.Forms.Label()
        Me.btnArticleInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(369, 316)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 13
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
        Me.txtArticle.TabIndex = 12
        '
        'lblArticle
        '
        Me.lblArticle.AutoSize = True
        Me.lblArticle.Location = New System.Drawing.Point(152, 81)
        Me.lblArticle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArticle.Name = "lblArticle"
        Me.lblArticle.Size = New System.Drawing.Size(37, 15)
        Me.lblArticle.TabIndex = 11
        Me.lblArticle.Text = "記事"
        '
        'btnArticleInsert
        '
        Me.btnArticleInsert.Location = New System.Drawing.Point(517, 316)
        Me.btnArticleInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArticleInsert.Name = "btnArticleInsert"
        Me.btnArticleInsert.Size = New System.Drawing.Size(131, 53)
        Me.btnArticleInsert.TabIndex = 14
        Me.btnArticleInsert.Text = "投稿"
        Me.btnArticleInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "記事"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 118)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(493, 177)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "記事"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(155, 118)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(493, 177)
        Me.TextBox2.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 316)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 53)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "戻る"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmArticleInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnArticleInsert)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArticle)
        Me.Controls.Add(Me.lblArticle)
        Me.Name = "frmArticleInsert"
        Me.Text = "frmArticleInsert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtArticle As TextBox
    Friend WithEvents lblArticle As Label
    Friend WithEvents btnArticleInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
