using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
	public class LazorBeam
	{
		public Animation LazorBeamAnimation;
		public Vector2 Position;
		public bool Active;
		public int LazorDamage;

		private int LazorBeamMoveSpeed;

		Viewport viewport;

		public int Width 
		{
			get { return LazorBeamAnimation.FrameWidth; }
		}

		public int Height
		{
			get { return LazorBeamAnimation.FrameHeight; }
		}

		public void Initialize(Animation animation, Vector2 position)
		{
			LazorBeamAnimation = animation;

			Position = position;

			Active = true;

			LazorDamage = 300;

			LazorBeamMoveSpeed = 10;
		}

		public void Update(GameTime gameTime)
		{
			LazorBeamAnimation.Position.X += LazorBeamMoveSpeed;
			LazorBeamAnimation.Update (gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			LazorBeamAnimation.Draw (spriteBatch);
		}
	}
}

