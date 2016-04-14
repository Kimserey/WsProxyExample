namespace Library1

module Animal =
    type Dog =
        { Name: string
          Age : int }

        static member Walk (x: Dog) =
            x.Name + " is walking!"

        static member SayHello (x: Dog) =
            x.Name + " never say hello"