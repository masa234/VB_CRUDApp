﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnUserRegister = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnUserUpdate = New System.Windows.Forms.Button()
        Me.btnTweetInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUserRegister
        '
        Me.btnUserRegister.Location = New System.Drawing.Point(77, 80)
        Me.btnUserRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUserRegister.Name = "btnUserRegister"
        Me.btnUserRegister.Size = New System.Drawing.Size(106, 40)
        Me.btnUserRegister.TabIndex = 5
        Me.btnUserRegister.Text = "ユーザ登録"
        Me.btnUserRegister.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(207, 80)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(106, 40)
        Me.btnUsers.TabIndex = 6
        Me.btnUsers.Text = "ユーザ一覧"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnUserUpdate
        '
        Me.btnUserUpdate.Location = New System.Drawing.Point(336, 80)
        Me.btnUserUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUserUpdate.Name = "btnUserUpdate"
        Me.btnUserUpdate.Size = New System.Drawing.Size(106, 40)
        Me.btnUserUpdate.TabIndex = 7
        Me.btnUserUpdate.Text = "ユーザ更新"
        Me.btnUserUpdate.UseVisualStyleBackColor = True
        '
        'btnTweetInsert
        '
        Me.btnTweetInsert.Location = New System.Drawing.Point(77, 152)
        Me.btnTweetInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTweetInsert.Name = "btnTweetInsert"
        Me.btnTweetInsert.Size = New System.Drawing.Size(106, 40)
        Me.btnTweetInsert.TabIndex = 8
        Me.btnTweetInsert.Text = "ツイート投稿"
        Me.btnTweetInsert.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 375)
        Me.Controls.Add(Me.btnTweetInsert)
        Me.Controls.Add(Me.btnUserUpdate)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnUserRegister)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUserRegister As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnUserUpdate As Button
    Friend WithEvents btnTweetInsert As Button
End Class
