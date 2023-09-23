namespace pHCalculator.WinUI

open System

module Program =
    [<EntryPoint; STAThread>]
    let main args =
        do FSharp.Maui.WinUICompat.Program.Main(args, typeof<pHCalculator.WinUI.App>)
        0
