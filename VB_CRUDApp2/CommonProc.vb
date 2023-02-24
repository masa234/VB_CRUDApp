Imports System.Data.SqlClient

Public Class CommonProc

    ''' <summary>
    ''' 文字列がおさまっているかどうか？
    ''' </summary>
    ''' 2023/02/11
    Public Shared Function IsFitInText(ByVal str As String,
                                ByVal maxLength As Long) As Boolean

        '空の場合、False
        If String.IsNullOrEmpty(str) Then
            Return False
        End If

        '文字数オーバーの場合、False
        If maxLength < str.Length Then
            Return False
        End If

        Return True

    End Function


    ''' <summary>
    ''' フォームを開く
    ''' </summary>
    ''' 2023/02/11
    Public Shared Sub HideAndOpen(ByVal openedForm As Form,
                                ByVal openForm As Form)

        'フォームを非表示にする
        openedForm.Hide()

        '表示
        openForm.Show()

    End Sub

End Class
