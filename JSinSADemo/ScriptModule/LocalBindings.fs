[<AutoOpen>]
module LocalBindings

open JSinSADemo.Types

type TweetHubServer =
    abstract member startAgents : unit -> unit

type FunScript.TypeScript.HubProxy with
    [<FunScript.JSEmitInline("{0}.server"); CompiledName("server")>]
    member this.server with get() : TweetHubServer = failwith "never"

type System.Object with
    [<FunScript.JSEmitInlineAttribute("{0}"); CompiledName("")>]
    member this.AsTweet with get() : Tweet = failwith "never"

    [<FunScript.JSEmitInline("{0}"); CompiledName("")>]
    member this.Ignore with get() : unit = failwith "never"

