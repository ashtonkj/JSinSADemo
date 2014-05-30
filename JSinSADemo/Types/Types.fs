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