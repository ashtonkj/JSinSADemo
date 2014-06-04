namespace JSinSADemo.Types

type TwitterUser = 
    {
        Name: string
        ScreenName: string
        ProfileImageUrl: string
    }

type UserMention = 
    {
        Name: string
        ScreenName: string
    }

type Tweet = 
    {
        Id: string
        Text: string
        CreatedAt: System.DateTime
        Creator: TwitterUser
        Source: string
        UserMentions: UserMention list
    }

type WordCount = 
    {
        text: string
        value: int
    }

type UserTweetCount = 
    {
        ScreenName: string
        TweetCount: int
    }

type TimedTweetCount = 
    {
        Time: string
        TweetCount: int
    }

type Message =
    | TweetReceived of Tweet: Tweet
    | WordCountGenerated of WordCount: WordCount seq
    | UserTweetCountGenerated of TweetCount : UserTweetCount seq
    | TweetTimeCountGenerated of TweetCount: TimedTweetCount seq
    | MostMentionsGenerated of TweetCount: UserTweetCount seq
