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

        public FNATestGame() : base()
        {
            graphics = new GraphicsDeviceManager(this);            
        }

        protected override void Initialize()
        {
            base.Initialize();
            int dpCount = Content.MountDataPath("test");
            FNALoggerEXT.LogInfo.Invoke($"Found {dpCount} mount points with name test");
            FNALoggerEXT.LogInfo.Invoke("FNA Test Project: initialised");
        }
    }
}
