Public Class frmTweetUpdate

    'ログインユーザID
    Private loginUserID As Long
    '更新対象ID
    Private updateTweetID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal updateTweetID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

        '更新対象ID
        Me.updateTweetID = updateTweetID

    End Sub

    Private Sub frmTweetUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnTweetUpdate_Click(sender As Object, e As EventArgs) Handles btnTweetUpdate.Click

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

            '更新
            If Not Tweet.TweetUpdate(tweetTxt, Me.loginUserID, Me.updateTweetID) Then
                'メッセージボックス
                MessageBox.Show(Constant.TWEET_UPDATE_FAILED,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.TWEET_UPDATE_SUCCESS,
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


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/02/16
    Private Sub InitForm()

        Dim tweetData As TweetData

        'ツイート情報
        tweetData = Tweet.GetTweet(updateTweetID)

        '画面に設定
        Me.txtTweet.Text = tweetData.Tweet

    End Sub

End Class