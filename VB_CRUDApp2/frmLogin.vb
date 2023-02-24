Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim loginUserID As Long
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

            'ユーザが存在するかどうか？
            If Not User.IsExistsUser(userName, password) Then
                'メッセージボックス
                Call MessageBox.Show(Constant.LOGIN_FAILED,
                                     Constant.CONFIRM,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Return
            End If

            'ユーザIDを取得
            loginUserID = User.GetUserID(userName, password)

            'メイン画面を開く
            CommonProc.HideAndOpen(Me, New frmMain(loginUserID))

        Catch ex As Exception
            'メッセージボックス
            Call MessageBox.Show(ex.Message,
                                 Constant.WARNING,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)
            Return
        End Try


    End Sub
End Class
