using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNATestProject
{
    public class FNATestGame2D : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch batch;
        Texture2D testTex;

        public FNATestGame2D() : base()
        {
            graphics = new GraphicsDeviceManager(this);
            batch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Initialize()
        {
            base.Initialize();
            Content.LogSearchPaths();
            int dpCountC = Content.MountDataPath("common");
            int dpCount2D = Content.MountDataPath("2d");
            FNALoggerEXT.LogInfo.Invoke($"Found {dpCountC} mount points with name common, {dpCount2D} with name 2d");

            string msg = Content.Load<string>("hellomessage.txt");
            FNALoggerEXT.LogInfo.Invoke($"A very important announcement: {msg}");
            Content.Release("hellomessage.txt");

            testTex = Content.Load<Texture2D>("textures/texture2dtest.png");
        }

        protected override void Update(GameTime gameTime)
        {
            
        }

        protected override void Draw(GameTime gameTime)
        {            
            GraphicsDevice.Clear(Color.Black);
            if (!(testTex is null))
            {
                batch.Begin();
                batch.Draw(testTex, new Vector2(100, 100), Color.White);
                batch.End();
            }

            base.Draw(gameTime);
        }
    }
}
