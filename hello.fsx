let folderlist = (System.Environment.CurrentDirectory   
    |> System.IO.Path.GetDirectoryName
    |> System.IO.Directory.GetDirectories)


for folder in folderlist do
    printfn "%s" folder
