Public Class frmArticleInsert

    'ログインユーザID
    Private loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub btnArticleInsert_Click(sender As Object, e As EventArgs) Handles btnArticleInsert.Click

        Try
            Dim articleTxt As String

            '記事
            articleTxt = txtArticle.Text

            '入力チェック(記事)
            If Not CommonProc.IsFitInText(articleTxt, Constant.ARTICLE_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.ARTICLE_LENGTH_INVALID,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '投稿
            If Not Article.ArticleInsert(articleTxt, loginUserID) Then
                'メッセージボックス
                MessageBox.Show(Constant.ARTICLE_INSERT_FAILED,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If

            '成功メッセージ
            MessageBox.Show(Constant.ARTICLE_INSERT_SUCCESS,
                            Constant.CONFIRM,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception

            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, Button1.Click

        Try
            'メイン画面を開く
            CommonProc.HideAndOpen(Me, New frmMain(loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub
End Class