namespace JSinSADemo.Types.Hubs

open JSinSADemo.Types.Subjects

type TweetHub() =
    inherit Microsoft.AspNet.SignalR.Hub()
    member this.Start() = 
        StartAgentsSubject.OnNext true