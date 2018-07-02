using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESC_Test
{
	[EntityComponent]
	[EntityComponentPool(InitialSize = 100)]
	class SpriteComponent : EntityComponent
	{
		public Texture2D Texture;

		public override void Reset()
		{

		}
	}
}
