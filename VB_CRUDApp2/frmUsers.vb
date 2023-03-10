Public Class frmUsers
    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'DataSourceを設定
            dgvUsers.DataSource = User.GetUsers

        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
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
            Call MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

        Dim deleteUserID As Long

        Try

            '削除ボタンが押されている場合
            If dgvUsers.Columns(e.ColumnIndex).Name = "btnUserDelete" Then

                '対象ID
                deleteUserID = Long.Parse(dgvUsers.Rows(e.RowIndex).Cells(1).Value.ToString())

                '削除
                If Not User.UserDelete(deleteUserID) Then
                    'メッセージボックス
                    Call MessageBox.Show(Constant.USER_DELETE_FAILED,
                                         Constant.CONFIRM,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                End If

                'DataSouceの再設定
                Me.dgvUsers.DataSource = User.GetUsers

            End If

        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub
End Class