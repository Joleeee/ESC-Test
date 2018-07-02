using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESC_Test
{
	[Aspect(AspectType.All, typeof(SpriteComponent), typeof(TransformComponent2D))]
	[EntitySystem(GameLoopType.Draw, Layer = 0)]
	class SpriteDrawingSystem : EntityProcessingSystem
	{
		SpriteBatch spriteBatch;

		public override void Initialize()
		{
			base.Initialize();
			spriteBatch = Game.Services.GetService<SpriteBatch>();
		}

		protected override void End(GameTime gameTime)
		{
			base.End(gameTime);
			spriteBatch.End();
		}

		protected override void Begin(GameTime gameTime)
		{
			base.Begin(gameTime);
			spriteBatch.Begin();
		}

		protected override void Process(GameTime gameTime, Entity entity)
		{
			var texture = entity.Get<SpriteComponent>().Texture;
			var trans = entity.Get<TransformComponent2D>();
			spriteBatch.Draw(texture, trans.Position, null, Color.White, trans.Rotation, Vector2.Zero, trans.Scale, SpriteEffects.None, 0);
		}
	}
}
