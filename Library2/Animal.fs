namespace Library2

open WebSharper

[<JavaScript>]
module Animal =
    type Cat =
        { Name: string
          Age : int }

        static member Jump (x: Cat) =
            x.Name + " cat is jumping!"

module Garden =
    open Animal

    let runInGarden (x: Cat) =
        x.Name + " is running in the garden!"