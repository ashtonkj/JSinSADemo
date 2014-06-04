[<FunScript.JS>]
module ScriptModule

open FunScript
open FunScript.TypeScript


let jq (selector: string) = Globals.Dollar.Invoke(selector)

let DrawTweet (input: obj[]) =
    let tweet = input.AsTweet
    let out = 
            "<div class='list-group-item'>" + 
            "<h4 class='list-group-item-heading'>" +
            "<img src='" + tweet.Creator.ProfileImageUrl + "'/>" + tweet.Creator.Name + " (" + tweet.Creator.ScreenName + ")" +
            "</h4>" +
            "<p class='list-group-item-text'>" + tweet.Text + "</p>" + 
            "</div>"
    jq("#TweetsBox")
        .prepend(out)
        .Ignore

let Main() =
    let hub = Globals.Dollar.connection.hub.createHubProxy("tweetHub")
    hub.on("tweetReceived", fun x -> DrawTweet x).Ignore
    Globals.Dollar.connection.hub.start()._doneOverload2(fun _ -> hub.server.startAgents())
