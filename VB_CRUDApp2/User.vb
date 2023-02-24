Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class User


    ''' <summary>
    ''' ユーザが存在するかどうか?
    ''' </summary>
    ''' 2023/02/11
    Public Shared Function IsExistsUser(ByVal userName As String,
                                        ByVal password As String) As Boolean

        Dim userCount As Long
        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化 
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password)
        })

        'SQL取得
        sql = Constant.GET_USERCOUNT_SQL

        'SQL実行
        userCount = db.ExecuteScalar(sql, paramList)

        '実行結果が1を超えている場合、True
        If 1 <= userCount Then
            Return True
        End If

        Return False

    End Function


    ''' <summary>
    ''' ユーザID取得
    ''' </summary>
    ''' 2023/02/11
    Public Shared Function GetUserID(ByVal userName As String,
                                        ByVal password As String) As Long

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim reader As SqlDataReader
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password)
        })

        'SQL取得
        sql = Constant.GET_USERID_SQL

        'SQL実行
        reader = db.ExecuteReader(sql, paramList)

        '読み込める間、繰り返す
        While reader.Read()
            'Long型に変換して返却
            Return Long.Parse(reader(0))
        End While

        Return 0

    End Function


    ''' <summary>
    ''' ユーザ登録
    ''' </summary>
    ''' 2023/02/11
    Public Shared Function UserRegister(ByVal userName As String,
                                        ByVal password As String) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password)
        })

        'SQL取得
        sql = Constant.USER_REGISTER_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' ユーザ一覧取得
    ''' </summary>
    ''' 2023/02/11
    Public Shared Function GetUsers() As DataTable

        Dim sql As String
        Dim db As DB

        'インスタンス化
        db = New DB

        'SQL取得
        sql = Constant.GET_USERS_SQL

        'データテーブル返却
        Return db.GetDt(sql)

    End Function


    ''' <summary>
    ''' ユーザ削除
    ''' </summary>
    ''' 2023/02/14
    Public Shared Function UserDelete(ByVal deleteUserID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteUserID)
        })

        'SQL取得
        sql = Constant.USER_DELETE_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' ユーザ取得
    ''' </summary>
    ''' 2023/02/14
    Public Shared Function GetUser(ByVal userID As Long) As UserData

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim user As UserData
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
                New SqlParameter("Id", userID)
        })

        'SQL取得
        sql = Constant.GET_USER_SQL

        'インスタンス化
        user = New UserData

        'SQL実行
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'ユーザ名
                user.UserName = reader(1)
                'パスワード
                user.Password = reader(2)

                Return user
            End While
        End Using

        Return user

    End Function


    ''' <summary>
    ''' ユーザ更新
    ''' </summary>
    ''' 2023/02/14
    Public Shared Function UserUpdate(ByVal userName As String,
                                        ByVal password As String,
                                        ByVal updateUserID As Long) As Boolean

        Dim sql As String
        Dim paramList As List(Of SqlParameter)
        Dim db As DB

        'インスタンス化
        db = New DB()

        'パラム設定
        paramList = New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password),
            New SqlParameter("Id", updateUserID)
        })

        'SQL取得
        sql = Constant.USER_UPDATE_SQL

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
