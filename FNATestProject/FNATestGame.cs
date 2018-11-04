using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNATestProject
{
    public class FNATestGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch batch;
        Texture2D testTex;

        public FNATestGame() : base()
        {
            graphics = new GraphicsDeviceManager(this);
            batch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Initialize()
        {
            base.Initialize();
            Content.LogSearchPaths();
            int dpCount = Content.MountDataPath("test");
            FNALoggerEXT.LogInfo.Invoke($"Found {dpCount} mount points with name test");

            string msg = Content.Load<string>("hellomessage.txt");
            FNALoggerEXT.LogInfo.Invoke($"A very important announcement: {msg}");
            Content.Release("hellomessage.txt");

            testTex = Content.Load<Texture2D>("textures/texture2dtest.png");
        }

        protected override void Draw(GameTime gameTime)
        {            
            GraphicsDevice.Clear(Color.Black);
            batch.Begin();
            batch.Draw(testTex, new Vector2(100, 100), Color.White);
            batch.End();

            base.Draw(gameTime);
        }
    }
}
