using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CDC RID: 31964
	[Token(Token = "0x2007CDC")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/fast-vignette.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Fast Vignette")]
	public class FastVignette : BaseEffect
	{
		// Token: 0x0602C9DC RID: 182748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9DC")]
		[Address(RVA = "0x287BCB0", Offset = "0x287A8B0", VA = "0x18287BCB0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9DD RID: 182749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9DD")]
		[Address(RVA = "0x287BC80", Offset = "0x287A880", VA = "0x18287BC80", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9DE RID: 182750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9DE")]
		[Address(RVA = "0x287BDF0", Offset = "0x287A9F0", VA = "0x18287BDF0")]
		public FastVignette()
		{
		}

		// Token: 0x04040463 RID: 263267
		[Token(Token = "0x4040463")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Vignette type.")]
		public FastVignette.ColorMode Mode;

		// Token: 0x04040464 RID: 263268
		[Token(Token = "0x4040464")]
		[FieldOffset(Offset = "0x2C")]
		[ColorUsage(false)]
		[Tooltip("The color to use in the vignette area.")]
		public Color Color;

		// Token: 0x04040465 RID: 263269
		[Token(Token = "0x4040465")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Center point.")]
		public Vector2 Center;

		// Token: 0x04040466 RID: 263270
		[Token(Token = "0x4040466")]
		[FieldOffset(Offset = "0x44")]
		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		// Token: 0x04040467 RID: 263271
		[Token(Token = "0x4040467")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		// Token: 0x02007CDD RID: 31965
		[Token(Token = "0x2007CDD")]
		public enum ColorMode
		{
			// Token: 0x04040469 RID: 263273
			[Token(Token = "0x4040469")]
			Classic,
			// Token: 0x0404046A RID: 263274
			[Token(Token = "0x404046A")]
			Desaturate,
			// Token: 0x0404046B RID: 263275
			[Token(Token = "0x404046B")]
			Colored
		}
	}
}
