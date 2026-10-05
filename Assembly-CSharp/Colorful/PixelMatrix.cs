using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CFE RID: 31998
	[Token(Token = "0x2007CFE")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/pixel-matrix.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Pixel Matrix")]
	public class PixelMatrix : BaseEffect
	{
		// Token: 0x0602CA3C RID: 182844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA3C")]
		[Address(RVA = "0x2881400", Offset = "0x2880000", VA = "0x182881400", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA3D RID: 182845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA3D")]
		[Address(RVA = "0x28813D0", Offset = "0x287FFD0", VA = "0x1828813D0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA3E RID: 182846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA3E")]
		[Address(RVA = "0x2881530", Offset = "0x2880130", VA = "0x182881530")]
		public PixelMatrix()
		{
		}

		// Token: 0x0404051B RID: 263451
		[Token(Token = "0x404051B")]
		[FieldOffset(Offset = "0x28")]
		[ColorMin(3f)]
		[Tooltip("Tile size. Works best with multiples of 3.")]
		public int Size;

		// Token: 0x0404051C RID: 263452
		[Token(Token = "0x404051C")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		[Tooltip("Tile brightness booster.")]
		public float Brightness;

		// Token: 0x0404051D RID: 263453
		[Token(Token = "0x404051D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Show / hide black borders on every tile.")]
		public bool BlackBorder;
	}
}
