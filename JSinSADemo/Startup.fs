namespace JSinSADemo

open Owin

type Startup() =
    member this.Configuration(app: Owin.IAppBuilder) =
        app.MapSignalR() |> ignore
        ()

