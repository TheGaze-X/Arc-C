using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D09 RID: 32009
	[Token(Token = "0x2007D09")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/strokes.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Strokes")]
	public class Strokes : BaseEffect
	{
		// Token: 0x0602CA59 RID: 182873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA59")]
		[Address(RVA = "0x2882C50", Offset = "0x2881850", VA = "0x182882C50", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA5A RID: 182874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA5A")]
		[Address(RVA = "0x2882C20", Offset = "0x2881820", VA = "0x182882C20", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA5B RID: 182875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA5B")]
		[Address(RVA = "0x2882E60", Offset = "0x2881A60", VA = "0x182882E60")]
		public Strokes()
		{
		}

		// Token: 0x04040546 RID: 263494
		[Token(Token = "0x4040546")]
		[FieldOffset(Offset = "0x28")]
		public Strokes.ColorMode Mode;

		// Token: 0x04040547 RID: 263495
		[Token(Token = "0x4040547")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.04f)]
		[Tooltip("Stroke rotation, or wave pattern amplitude.")]
		public float Amplitude;

		// Token: 0x04040548 RID: 263496
		[Token(Token = "0x4040548")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 20f)]
		[Tooltip("Wave pattern frequency (higher means more waves).")]
		public float Frequency;

		// Token: 0x04040549 RID: 263497
		[Token(Token = "0x4040549")]
		[FieldOffset(Offset = "0x34")]
		[Range(4f, 12f)]
		[Tooltip("Global scaling.")]
		public float Scaling;

		// Token: 0x0404054A RID: 263498
		[Token(Token = "0x404054A")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.1f, 0.5f)]
		[Tooltip("Stroke maximum thickness.")]
		public float MaxThickness;

		// Token: 0x0404054B RID: 263499
		[Token(Token = "0x404054B")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("Contribution threshold (higher means more continous strokes).")]
		public float Threshold;

		// Token: 0x0404054C RID: 263500
		[Token(Token = "0x404054C")]
		[FieldOffset(Offset = "0x40")]
		[Range(-0.3f, 0.3f)]
		[Tooltip("Stroke pressure.")]
		public float Harshness;

		// Token: 0x0404054D RID: 263501
		[Token(Token = "0x404054D")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the strokes.")]
		public float RedLuminance;

		// Token: 0x0404054E RID: 263502
		[Token(Token = "0x404054E")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Amount of green to contribute to the strokes.")]
		public float GreenLuminance;

		// Token: 0x0404054F RID: 263503
		[Token(Token = "0x404054F")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("Amount of blue to contribute to the strokes.")]
		public float BlueLuminance;

		// Token: 0x02007D0A RID: 32010
		[Token(Token = "0x2007D0A")]
		public enum ColorMode
		{
			// Token: 0x04040551 RID: 263505
			[Token(Token = "0x4040551")]
			BlackAndWhite,
			// Token: 0x04040552 RID: 263506
			[Token(Token = "0x4040552")]
			WhiteAndBlack,
			// Token: 0x04040553 RID: 263507
			[Token(Token = "0x4040553")]
			ColorAndWhite,
			// Token: 0x04040554 RID: 263508
			[Token(Token = "0x4040554")]
			ColorAndBlack,
			// Token: 0x04040555 RID: 263509
			[Token(Token = "0x4040555")]
			WhiteAndColor,
			// Token: 0x04040556 RID: 263510
			[Token(Token = "0x4040556")]
			BlackAndColor
		}
	}
}
