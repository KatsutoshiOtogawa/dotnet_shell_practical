
// let f1 x = printfn "%s" x
open System.Collections.Generic

(
System.Environment.CurrentDirectory   
    |> System.IO.Path.GetDirectoryName
    |> System.IO.Directory.GetDirectories
    |> Array.iter (fun (x:string) -> printfn "%s" x)
)
