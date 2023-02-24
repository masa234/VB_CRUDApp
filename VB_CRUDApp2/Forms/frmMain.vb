Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmMain

    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub btnUserRegister_Click(sender As Object, e As EventArgs) Handles btnUserRegister.Click

        Try
            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmUserRegister(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
           MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

        Try
            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmUsers(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
           MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUserUpdate_Click(sender As Object, e As EventArgs) Handles btnUserUpdate.Click

        Try
            'フォームを開く            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmUserUpdate(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
           MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnTweetInsert_Click(sender As Object, e As EventArgs) Handles btnTweetInsert.Click

        Try
            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmTweetInsert(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
           MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnTweets_Click(sender As Object, e As EventArgs) Handles btnTweets.Click

        Try
            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmTweets(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
           MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnArticleInsert_Click(sender As Object, e As EventArgs) Handles btnArticleInsert.Click

        Try
            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmArticleInsert(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                                  Constant.WARNING,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnArticles_Click(sender As Object, e As EventArgs) Handles btnArticles.Click

        Try
            '記事一覧画面を開く
            CommonProc.HideAndOpen(Me, New frmArticles(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                                  Constant.WARNING,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error)
        End Try

    End Sub
End Class