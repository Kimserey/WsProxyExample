namespace ProxyExample

open Library1.Animal
open Library2
open Library2.Animal
open Library3

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client  

[<JavaScript; Proxy(typeof<Dog>)>]
type Dog' =
    { Name: string
      Age: int }

    static member Walk(x:Dog)  =
        x.Name + " is walking"

    [<Inline "$x.Test + ' said hello'">]
    static member SayHello(x:Dog) = X<string>

[<JavaScript>]        
[<Proxy "Library2.Garden, Culture=neutral">]
module Garden' =

    let runInGarden (x: Cat) =
        x.Name + " run in second garden hehe!"

[<JavaScript>]
module Client =  

    let dog: Dog =
        As({ Name = "dog"
             Age = 5 })
             
    let cat: Cat =
        { Name = "cat"
          Age = 5 }

    let main =
        [ text (Dog.Walk dog)
          br [] :> Doc
          text (Dog.SayHello dog)
          br [] :> Doc
          text (Garden.runInGarden cat)
          br [] :> Doc
          text (Cat.Jump cat) ]
        |> Doc.Concat
        |> Doc.RunById "main"
