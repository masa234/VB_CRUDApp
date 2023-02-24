Public Class Constant


    'メッセージ
    Public Const USERNAME_LENGTH_INVALID = "ユーザ名は1～255文字以内で指定してください。"
    Public Const PASSWORD_LENGTH_INVALID = "パスワードは1～255文字以内で指定してください。"
    Public Const TWEET_LENGTH_INVALID = "ツイートは1～140文字以内で指定してください。"
    Public Const ARTICLE_LENGTH_INVALID = "記事は1～255文字以内で指定してください。"
    Public Const LOGIN_FAILED = "ログインに失敗しました。"
    '失敗メッセージ
    Public Const USER_REGISTER_FAILED = "ユーザ登録に失敗しました。"
    Public Const USER_DELETE_FAILED = "ユーザ削除に失敗しました。"
    Public Const USER_UPDATE_FAILED = "ユーザ更新に失敗しました。"
    Public Const TWEET_INSERT_FAILED = "ツイート投稿に失敗しました。"
    Public Const TWEET_DELETE_FAILED = "ツイート削除に失敗しました。"
    Public Const TWEET_UPDATE_FAILED = "ツイート更新に失敗しました。"
    Public Const ARTICLE_INSERT_FAILED = "記事投稿に失敗しました。"
    Public Const ARTICLE_DELETE_FAILED = "記事削除に失敗しました。"
    Public Const ARTICLE_UPDATE_FAILED = "記事更新に失敗しました。"
    '成功メッセージ
    Public Const USER_REGISTER_SUCCESS = "ユーザ登録に成功しました。"
    Public Const USER_UPDATE_SUCCESS = "ユーザ更新に成功しました。"
    Public Const TWEET_INSERT_SUCCESS = "ツイート投稿に成功しました。"
    Public Const TWEET_UPDATE_SUCCESS = "ツイート更新に成功しました。"
    Public Const ARTICLE_INSERT_SUCCESS = "記事投稿に成功しました。"
    Public Const ARTICLE_UPDATE_SUCCESS = "記事更新に成功しました。"
    '接続文字列
    Public Const CONNECTION_STRING = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'メッセージタイトル
    Public Const CONFIRM = "確認"
    Public Const WARNING = "警告"
    '最大文字数
    Public Const USERNAME_MAX_LENGTH = 255
    Public Const PASSWORD_MAX_LENGTH = 255
    Public Const ARTICLE_MAX_LENGTH = 255
    Public Const TWEET_MAX_LENGTH = 140

    'SQL
    Public Const GET_USERCOUNT_SQL = "SELECT " &
                                    "  COUNT(*) " &
                                    "FROM " &
                                    "  Users " &
                                    "WHERE " &
                                    "  UserName = " &
                                    "  @UserName " &
                                    "AND " &
                                    "  Password = " &
                                    "  @Password "
    Public Const GET_USERID_SQL = "SELECT " &
                                    "  Id " &
                                    "FROM " &
                                    "  Users " &
                                    "WHERE " &
                                    "  UserName = " &
                                    "  @UserName " &
                                    "AND " &
                                    "  Password = " &
                                    "  @Password "
    Public Const USER_REGISTER_SQL = "INSERT " &
                                    "  INTO " &
                                    "Users " &
                                    "  (UserName, " &
                                    "  Password) " &
                                    "VALUES " &
                                    "  (@UserName, " &
                                    "  @Password) "
    Public Const GET_USERS_SQL = "SELECT " &
                                "  Id, " &
                                "  UserName, " &
                                "  Password " &
                                "FROM " &
                                "  Users " &
                                "ORDER BY " &
                                "  Id "
    Public Const USER_DELETE_SQL = "DELETE " &
                                "     FROM " &
                                "   Users " &
                                "   WHERE " &
                                "     Id = @Id "
    Public Const GET_USER_SQL = "SELECT " &
                                "  Id, " &
                                "  UserName, " &
                                "  Password " &
                                "FROM " &
                                "  Users " &
                                "WHERE " &
                                "  Id = @Id "
    Public Const USER_UPDATE_SQL = " UPDATE " &
                                    "Users " &
                                    "  SET " &
                                    "    UserName = @UserName, " &
                                    "    Password = @Password " &
                                    "WHERE " &
                                    "  Id = @Id "
    Public Const TWEET_INSERT_SQL = "INSERT " &
                                    "  INTO " &
                                    "Tweets " &
                                    "  (Tweet, " &
                                    "  UserId) " &
                                    "VALUES " &
                                    "  (@Tweet, " &
                                    "  @UserId) "
    Public Const GET_TWEETS_SQL = "SELECT " &
                                "    Id, " &
                                "    Tweet " &
                                "  FROM " &
                                "    Tweets " &
                                "  ORDER BY " &
                                "    Id "
    Public Const TWEET_DELETE_SQL = "DELETE " &
                                "     FROM " &
                                "   Tweets " &
                                "   WHERE " &
                                "     Id = @Id "
    Public Const GET_TWEET_SQL = "SELECT " &
                                "  Tweet " &
                                "FROM " &
                                "  Tweets " &
                                "WHERE " &
                                "  Id = @Id "
    Public Const UPDATE_TWEET_SQL = " UPDATE " &
                                    "   Tweets " &
                                    " SET " &
                                    "   Tweet = @Tweet, " &
                                    "   UserId = @UserId " &
                                    "WHERE " &
                                    "  Id = @Id "
    Public Const ARTICLE_INSERT_SQL = "INSERT " &
                                    "    INTO " &
                                    "  Articles " &
                                    "    (Article, " &
                                    "    UserId) " &
                                    "  VALUES " &
                                    "    (@Article, " &
                                    "     @UserId) "
    Public Const GET_ARTICLES_SQL = "SELECT " &
                                    "  Id, " &
                                    "  Article " &
                                    "FROM " &
                                    "  Articles " &
                                    "ORDER BY " &
                                    "  Id "
    Public Const ARTICLE_DELETE_SQL = "DELETE " &
                                    "    FROM " &
                                    "  Articles " &
                                    "  WHERE " &
                                    "    Id = @Id "
    Public Const GET_ARTICLE_SQL = "SELECT " &
                                    "  Article " &
                                    "FROM " &
                                    "  Articles " &
                                    "WHERE " &
                                    "  Id = @Id "
    Public Const ARTICLE_UPDATE_SQL = "  UPDATE " &
                                        "  Articles " &
                                        "SET " &
                                        "  Article = @Article, " &
                                        "  UserId = @UserId " &
                                        "WHERE " &
                                        "  Id = @Id "
End Class
