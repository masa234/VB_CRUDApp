Imports System.Runtime.CompilerServices

Public Class frmArticles

    'ログインユーザID
    Private loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub frmArticles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub dgvTweets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticles.CellContentClick

        Try
            Dim articleID As Long

            '対象ID
            articleID = Long.Parse(dgvArticles.Rows(e.RowIndex).Cells(2).Value.ToString())

            '削除ボタンが押されている場合
            If dgvArticles.Columns(e.ColumnIndex).Name = "btnArticleDelete" Then

                '削除
                If Not Article.ArticleDelete(articleID) Then
                    'メッセージボックス
                    MessageBox.Show(Constant.ARTICLE_DELETE_FAILED,
                                         Constant.CONFIRM,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                    Return

                End If

                'データソース再設定
                SetDataSource()

            End If

            '更新ボタンが押されている場合
            If dgvArticles.Columns(e.ColumnIndex).Name = "btnArticleUpdate" Then

                '更新画面に遷移
                CommonProc.HideAndOpen(Me, New frmArticleUpdate(Me.loginUserID, articleID))

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
    ''' 2023/02/23
    Private Sub InitForm()

        'データソースを設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソース設定
    ''' </summary>
    ''' 2023/02/23
    Private Sub SetDataSource()

        'データソースを設定
        Me.dgvArticles.DataSource = Article.GetArticles()

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
End Class