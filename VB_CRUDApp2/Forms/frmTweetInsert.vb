Public Class frmTweetInsert

    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

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

    Private Sub btnTweetInsert_Click(sender As Object, e As EventArgs) Handles btnTweetInsert.Click

        Try
            Dim tweetTxt As String

            'ツイート
            tweetTxt = txtTweet.Text

            '入力チェック(ツイート)
            If Not CommonProc.IsFitInText(tweetTxt, Constant.TWEET_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.TWEET_LENGTH_INVALID,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            '登録
            If Not Tweet.TweetInsert(tweetTxt, loginUserID) Then
                'メッセージボックス
                MessageBox.Show(Constant.TWEET_INSERT_FAILED,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.TWEET_INSERT_SUCCESS,
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

End Class