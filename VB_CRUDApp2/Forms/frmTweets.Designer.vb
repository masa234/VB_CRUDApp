<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTweets
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
        Me.dgvTweets = New System.Windows.Forms.DataGridView()
        Me.txtTweet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTweetDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnTweetUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvTweets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(481, 325)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvTweets
        '
        Me.dgvTweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTweets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtTweet, Me.txtId, Me.btnTweetDelete, Me.btnTweetUpdate})
        Me.dgvTweets.Location = New System.Drawing.Point(191, 120)
        Me.dgvTweets.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTweets.Name = "dgvTweets"
        Me.dgvTweets.RowHeadersWidth = 62
        Me.dgvTweets.RowTemplate.Height = 27
        Me.dgvTweets.Size = New System.Drawing.Size(421, 180)
        Me.dgvTweets.TabIndex = 11
        '
        'txtTweet
        '
        Me.txtTweet.DataPropertyName = "Tweet"
        Me.txtTweet.HeaderText = "ツイート"
        Me.txtTweet.MinimumWidth = 8
        Me.txtTweet.Name = "txtTweet"
        Me.txtTweet.Width = 150
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
        'btnTweetDelete
        '
        Me.btnTweetDelete.HeaderText = "ツイート削除"
        Me.btnTweetDelete.MinimumWidth = 8
        Me.btnTweetDelete.Name = "btnTweetDelete"
        Me.btnTweetDelete.Width = 150
        '
        'btnTweetUpdate
        '
        Me.btnTweetUpdate.HeaderText = "ツイート更新"
        Me.btnTweetUpdate.MinimumWidth = 6
        Me.btnTweetUpdate.Name = "btnTweetUpdate"
        Me.btnTweetUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnTweetUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnTweetUpdate.Width = 125
        '
        'frmTweets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvTweets)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmTweets"
        Me.Text = "frmTweet"
        CType(Me.dgvTweets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvTweets As DataGridView
    Friend WithEvents txtTweet As DataGridViewTextBoxColumn
    Friend WithEvents txtId As DataGridViewTextBoxColumn
    Friend WithEvents btnTweetDelete As DataGridViewButtonColumn
    Friend WithEvents btnTweetUpdate As DataGridViewButtonColumn
End Class
