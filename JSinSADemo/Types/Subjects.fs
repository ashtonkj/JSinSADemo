module public JSinSADemo.Types.Subjects

open System.Reactive.Subjects

let StreamLineReceivedSubject = new Subject<string>()
let StartAgentsSubject = new Subject<bool>()
let TweetReceivedSubject = new Subject<Tweet>()
let MessageReceivedSubject = new Subject<Message>()