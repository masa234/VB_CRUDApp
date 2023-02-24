Imports System.Data.SqlClient

Public Class DB
    Implements IDisposable
    'コネクション
    Private Property con As SqlConnection

    'トランザクション
    Private Property tran As SqlTransaction

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' 2023/02/11
    Public Sub New()

        'コネクションを開く
        ConOpen()

        'トランザクション開始
        BeginTran()

    End Sub



    ''' <summary>
    ''' コネクションオープン
    ''' </summary>
    ''' 2023/02/11
    Private Sub ConOpen()


        'コネクションが存在しない場合
        If Me.con Is Nothing Then

            'コネクションを作成
            Me.con = New SqlConnection

            '接続文字列を追加する
            Me.con.ConnectionString = Constant.CONNECTION_STRING

            'コネクションを開く
            Me.con.Open()
        End If


    End Sub


    ''' <summary>
    ''' トランザクション開始
    ''' </summary>
    ''' 2023/02/11
    Private Sub BeginTran()

        'トランザクションが存在しない場合
        If Me.tran Is Nothing Then

            'トランザクション開始
            Me.tran = Me.con.BeginTransaction

        End If

    End Sub


    ''' <summary>
    ''' コミット
    ''' </summary>
    ''' 2023/02/11
    Private Sub Commit()

        'トランザクションが存在する場合
        If Not Me.tran Is Nothing Then

            'トランザクション開始
            Me.tran.Commit()

            'トランザクションを空にする
            Me.tran = Nothing

        End If

    End Sub


    ''' <summary>
    ''' コミット
    ''' </summary>
    ''' 2023/02/11
    Private Sub RollBack()

        'トランザクションが存在する場合
        If Not Me.tran Is Nothing Then

            'トランザクション開始
            Me.tran.Rollback()

            'トランザクションを空にする
            Me.tran = Nothing

        End If

    End Sub


    ''' <summary>
    ''' INSERT, UPDATE, DELETE用
    ''' </summary>
    ''' 2023/02/11
    Public Sub ExecuteNonQuery(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing)

        Try
            'コマンド作成
            Using cmd = New SqlCommand(sql, Me.con, Me.tran)

                'パラメータが存在する場合
                If Not paramList Is Nothing Then
                    'パラメータ追加
                    cmd.Parameters.AddRange(paramList.ToArray())
                End If

                'SQL実行
                cmd.ExecuteNonQuery()

                'コミット
                Commit()

            End Using
        Catch ex As Exception

            'ロールバック
            RollBack()

            '例外を投げる
            Throw

        End Try


    End Sub



    ''' <summary>
    ''' SELECT COUNT用
    ''' </summary>
    ''' 2023/02/11
    Public Function ExecuteScalar(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As Long

        Dim dataCount As Long

        'コマンド作成
        Using cmd = New SqlCommand(sql, Me.con, Me.tran)
            'パラメータが存在する場合
            If Not paramList Is Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray())
            End If

            'SQL実行
            dataCount = Long.Parse(cmd.ExecuteScalar())

            Return dataCount

        End Using

    End Function


    ''' <summary>
    ''' SELECT用
    ''' </summary>
    ''' 2023/02/11
    Public Function ExecuteReader(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As SqlDataReader

        'コマンド作成
        Using cmd = New SqlCommand(sql, Me.con, Me.tran)
            'パラメータが存在する場合
            If Not paramList Is Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray())
            End If

            'リーダーを返却
            Return cmd.ExecuteReader

        End Using

    End Function


    ''' <summary>
    ''' SELECT用
    ''' </summary>
    ''' 2023/02/11
    Public Function GetDt(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As DataTable

        Dim dt As DataTable

        'コマンド作成
        Using cmd = New SqlCommand(sql, Me.con, Me.tran)
            'パラメータが存在する場合
            If Not paramList Is Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray())
            End If

            'アダプター作成
            Using adapter = New SqlDataAdapter(cmd)

                'データテーブル作成
                dt = New DataTable

                adapter.Fill(dt)

                Return dt

            End Using

        End Using

    End Function


    ''' <summary>
    ''' 破棄
    ''' </summary>
    ''' 2023/02/11
    Public Sub DisposeAllObject() Implements IDisposable.Dispose

        'コネクションが存在する場合
        If Not Me.con Is Nothing Then

            'コネクションが開いている場合
            If Me.con.State = ConnectionState.Connecting Then
                'コネクションを閉じる
                Me.con.Close()
            End If

            'コネクションを破棄
            Me.con = Nothing

        End If

        'トランザクションが存在する場合
        If Not Me.tran Is Nothing Then

            'トランザクション破棄
            Me.tran = Nothing

        End If


    End Sub


    ''' <summary>
    ''' デストラクタ
    ''' </summary>
    ''' 2023/02/11
    Protected Overrides Sub Finalize()

        'オブジェクト破棄
       DisposeAllObject()

    End Sub




End Class
