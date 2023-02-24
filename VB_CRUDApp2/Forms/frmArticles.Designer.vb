<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticles
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
        Me.dgvArticles = New System.Windows.Forms.DataGridView()
        Me.txtArticle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnArticleDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnArticleUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvArticles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvArticles
        '
        Me.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtArticle, Me.txtId, Me.btnArticleDelete, Me.btnArticleUpdate})
        Me.dgvArticles.Location = New System.Drawing.Point(169, 114)
        Me.dgvArticles.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvArticles.Name = "dgvArticles"
        Me.dgvArticles.RowHeadersWidth = 62
        Me.dgvArticles.RowTemplate.Height = 27
        Me.dgvArticles.Size = New System.Drawing.Size(421, 180)
        Me.dgvArticles.TabIndex = 13
        '
        'txtArticle
        '
        Me.txtArticle.DataPropertyName = "Article"
        Me.txtArticle.HeaderText = "記事"
        Me.txtArticle.MinimumWidth = 8
        Me.txtArticle.Name = "txtArticle"
        Me.txtArticle.Width = 150
        '
        'txtId
        '
        Me.txtId.DataPropertyName = "Id"
        Me.txtId.HeaderText = "ID"
        Me.txtId.MinimumWidth = 8
        Me.txtId.Name = "txtId"
        Me.txtId.Visible = False
        Me.txtId.Width = 150
        '
        'btnArticleDelete
        '
        Me.btnArticleDelete.HeaderText = "記事削除"
        Me.btnArticleDelete.MinimumWidth = 8
        Me.btnArticleDelete.Name = "btnArticleDelete"
        Me.btnArticleDelete.Width = 150
        '
        'btnArticleUpdate
        '
        Me.btnArticleUpdate.HeaderText = "記事更新"
        Me.btnArticleUpdate.MinimumWidth = 6
        Me.btnArticleUpdate.Name = "btnArticleUpdate"
        Me.btnArticleUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnArticleUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnArticleUpdate.Width = 125
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(459, 319)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmArticles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvArticles)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmArticles"
        Me.Text = "frmArticles"
        CType(Me.dgvArticles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvArticles As DataGridView
    Friend WithEvents txtArticle As DataGridViewTextBoxColumn
    Friend WithEvents txtId As DataGridViewTextBoxColumn
    Friend WithEvents btnArticleDelete As DataGridViewButtonColumn
    Friend WithEvents btnArticleUpdate As DataGridViewButtonColumn
    Friend WithEvents btnBack As Button
End Class
