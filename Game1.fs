namespace MyGame

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1 () as this =
    inherit Game ()

    let _graphics = new GraphicsDeviceManager(this)
    let mutable _spriteBatch = Unchecked.defaultof<SpriteBatch>

    do
        this.Content.RootDirectory <- "Content"
        this.IsMouseVisible <- true

    override _.Initialize () =
        base.Initialize()

    override _.LoadContent () =
        _spriteBatch <- new SpriteBatch(this.GraphicsDevice)

    override _.Update (gameTime: GameTime) =
        if GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape) then
            this.Exit()

        base.Update(gameTime)

    override this.Draw (gameTime: GameTime) =
        this.GraphicsDevice.Clear(Color.CornflowerBlue)

        base.Draw(gameTime)