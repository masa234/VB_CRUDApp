Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmUserUpdate

    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID


    End Sub

    Private Sub frmUserUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'フォーム初期化
            InitForm()

        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUserUpdate_Click(sender As Object, e As EventArgs) Handles btnUserUpdate.Click

        Try
            Dim userName As String
            Dim password As String

            'ユーザ名
            userName = txtUserName.Text
            'パスワード
            password = txtPassword.Text

            '入力チェック(ユーザ名)
            If Not CommonProc.IsFitInText(userName, Constant.USERNAME_MAX_LENGTH) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.USERNAME_LENGTH_INVALID,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                'フォーカス移動
                txtUserName.Focus()
                Return
            End If

            '入力チェック（パスワード）
            If Not CommonProc.IsFitInText(password, Constant.PASSWORD_MAX_LENGTH) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.PASSWORD_LENGTH_INVALID,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                'フォーカス移動
                txtPassword.Focus()
                Return
            End If

            '更新
            If Not User.UserUpdate(userName, password, loginUserID) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.USER_UPDATE_FAILED,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            Call MessageBox.Show(Constant.USER_UPDATE_SUCCESS,
                                 Constant.CONFIRM,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information)

        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub InitForm()

        Dim userData As UserData

        'ユーザ情報を取得
        userData = User.GetUser(loginUserID)

        '画面に設定
        'ユーザ名
        Me.txtUserName.Text = userData.UserName
        'パスワード
        Me.txtPassword.Text = userData.Password

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Try

            'フォームを開く
            CommonProc.HideAndOpen(Me, New frmMain(loginUserID))


        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
                             Constant.WARNING,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error)
        End Try

    End Sub
End Class