Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmUserRegister

    'ログインユーザID
    Public loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub btnUserRegister_Click(sender As Object, e As EventArgs) Handles btnUserRegister.Click, Button1.Click

        Dim userName As String
        Dim password As String

        Try
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
                Return
            End If

            '入力チェック（パスワード）
            If Not CommonProc.IsFitInText(password, Constant.PASSWORD_MAX_LENGTH) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.PASSWORD_LENGTH_INVALID,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            'ユーザ登録
            If Not User.UserRegister(userName, password) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.USER_REGISTER_FAILED,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            Call MessageBox.Show(Constant.USER_REGISTER_SUCCESS,
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, Button2.Click

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

End Class