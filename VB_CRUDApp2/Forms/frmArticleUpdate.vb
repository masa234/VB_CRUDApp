Public Class frmArticleUpdate

    'ログインユーザID
    Private loginUserID As Long
    '更新対象記事ID
    Private updateArticleID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal updateArticleID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '設定
        'ログインユーザID
        Me.loginUserID = loginUserID
        '更新対象記事ID
        Me.updateArticleID = updateArticleID

    End Sub

    Private Sub ArticleUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'フォーム初期化
            InitForm()

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                          Constant.WARNING,
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnArticleUpdate_Click(sender As Object, e As EventArgs) Handles btnArticleUpdate.Click

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

            '更新
            If Not Article.ArticleUpdate(articleTxt, Me.loginUserID, Me.updateArticleID) Then
                'メッセージボックス
                MessageBox.Show(Constant.ARTICLE_UPDATE_FAILED,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.ARTICLE_UPDATE_SUCCESS,
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Try

            'メイン画面に遷移
            CommonProc.HideAndOpen(Me, New frmMain(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                          Constant.WARNING,
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub InitForm()

        Dim articleData As ArticleData

        '記事情報を取得
        articleData = Article.GetArticle(updateArticleID)

        '画面に設定
        '記事
        Me.txtArticle.Text = articleData.Article

    End Sub

End Class