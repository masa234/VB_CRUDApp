Imports System.Data.SqlClient

Public Class Article

    ''' <summary>
    ''' 記事投稿
    ''' </summary>
    ''' 2023/02/23
    Public Shared Function ArticleInsert(ByVal article As String,
                                         ByVal loginUserID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Article", article),
            New SqlParameter("UserId", loginUserID)
        })

        'SQL取得
        sql = Constant.ARTICLE_INSERT_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 記事一覧取得
    ''' </summary>
    ''' 2023/02/23
    Public Shared Function GetArticles() As DataTable

        Dim sql As String
        Dim db As DB

        'インスタンス化
        db = New DB()

        'SQL取得
        sql = Constant.GET_ARTICLES_SQL

        'データテーブル返却
        Return db.GetDt(sql)

    End Function


    ''' <summary>
    ''' 記事削除
    ''' </summary>
    ''' 2023/02/23
    Public Shared Function ArticleDelete(ByVal deleteArticleID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteArticleID)
        })

        'SQL取得
        sql = Constant.ARTICLE_DELETE_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 記事取得
    ''' </summary>
    ''' 2023/02/23
    Public Shared Function GetArticle(ByVal articleID As Long) As ArticleData

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim article As ArticleData
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
                New SqlParameter("Id", articleID)
        })

        'SQL取得
        sql = Constant.GET_ARTICLE_SQL

        'インスタンス化
        article = New ArticleData

        'SQL実行
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                '設定
                article.Article = reader(0)

                Return article
            End While
        End Using

        Return article

    End Function


    ''' <summary>
    ''' 記事更新
    ''' </summary>
    ''' 2023/02/23
    Public Shared Function ArticleUpdate(ByVal article As String,
                                         ByVal updateUserID As Long,
                                         ByVal updateArticleID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Article", article),
            New SqlParameter("UserId", updateUserID),
            New SqlParameter("Id", updateArticleID)
        })

        'SQL取得
        sql = Constant.ARTICLE_UPDATE_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
