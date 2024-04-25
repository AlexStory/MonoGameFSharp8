open MyGame
open System

[<STAThread; EntryPoint>]
let main argv =
        use game = new Game1()
        game.Run ()
        0