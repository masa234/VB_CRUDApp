Public Class frmTweets

    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub frmTweets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Try
            'フォーム初期化
            CommonProc.HideAndOpen(Me, New frmMain(loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dgvTweets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTweets.CellContentClick

        Try
            Dim tweetID As Long

            '対象ID
            tweetID = Long.Parse(dgvTweets.Rows(e.RowIndex).Cells(2).Value.ToString())

            '削除ボタンが押されている場合
            If dgvTweets.Columns(e.ColumnIndex).Name = "btnTweetDelete" Then

                '削除
                If Not Tweet.TweetDelete(tweetID) Then
                    'メッセージボックス
                    MessageBox.Show(Constant.TWEET_DELETE_FAILED,
                                         Constant.CONFIRM,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                    Return
                End If

                'データソースの再設定
                SetDataSource()

            End If

            '更新ボタンが押されている場合
            If dgvTweets.Columns(e.ColumnIndex).Name = "btnTweetUpdate" Then

                '更新画面に遷移
                CommonProc.HideAndOpen(Me, New frmTweetUpdate(loginUserID, tweetID))

            End If

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

        'データソース設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソース設定
    ''' </summary>
    ''' 2023/02/16
    Private Sub SetDataSource()

        'データソース設定
        Me.dgvTweets.DataSource = Tweet.GetTweets

    End Sub

End Class