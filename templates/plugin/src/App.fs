module App

open Fable.Cumcord.TopLevel
open Fable.Core.JsInterop

printfn $"plugin loaded %s{cum None None}"

let onUnload () =
    printfn "plugin unloaded"