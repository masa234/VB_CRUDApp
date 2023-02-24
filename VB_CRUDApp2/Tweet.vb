Imports System.Data.SqlClient

Public Class Tweet

    ''' <summary>
    ''' ツイート投稿
    ''' </summary>
    ''' 2023/02/14
    Public Shared Function TweetInsert(ByVal tweet As String,
                                        ByVal createUserID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Tweet", tweet),
            New SqlParameter("UserId", createUserID)
        })

        'SQL取得
        sql = Constant.TWEET_INSERT_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' ツイート一覧取得
    ''' </summary>
    ''' 2023/02/16
    Public Shared Function GetTweets() As DataTable

        Dim sql As String
        Dim db As DB

        'インスタンス化
        db = New DB

        'SQL取得
        sql = Constant.GET_TWEETS_SQL

        'データテーブル返却
        Return db.GetDt(sql)

    End Function


    ''' <summary>
    ''' ツイート削除
    ''' </summary>
    ''' 2023/02/16
    Public Shared Function TweetDelete(ByVal deleteTweetID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteTweetID)
        })

        'SQL取得
        sql = Constant.TWEET_DELETE_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' ツイート取得
    ''' </summary>
    ''' 2023/02/14
    Public Shared Function GetTweet(ByVal tweetID As Long) As TweetData

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim tweet As TweetData
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
                New SqlParameter("Id", tweetID)
        })

        'SQL取得
        sql = Constant.GET_TWEET_SQL

        'インスタンス化
        tweet = New TweetData

        'SQL実行
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'ツイート
                tweet.Tweet = reader(0)

                Return tweet
            End While
        End Using

        Return tweet

    End Function


    ''' <summary>
    ''' ツイート更新
    ''' </summary>
    ''' 2023/02/16
    Public Shared Function TweetUpdate(ByVal tweet As String,
                                       ByVal loginUserID As Long,
                                       ByVal updateTweetID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Tweet", tweet),
            New SqlParameter("UserId", loginUserID),
            New SqlParameter("Id", updateTweetID)
        })

        'SQL取得
        sql = Constant.UPDATE_TWEET_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
