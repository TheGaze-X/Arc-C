using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CEF RID: 31983
	[Token(Token = "0x2007CEF")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/lens-distortion-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Lens Distortion Blur")]
	public class LensDistortionBlur : BaseEffect
	{
		// Token: 0x0602CA11 RID: 182801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA11")]
		[Address(RVA = "0x287E950", Offset = "0x287D550", VA = "0x18287E950", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA12 RID: 182802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA12")]
		[Address(RVA = "0x287E920", Offset = "0x287D520", VA = "0x18287E920", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA13 RID: 182803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA13")]
		[Address(RVA = "0x287EA50", Offset = "0x287D650", VA = "0x18287EA50")]
		public LensDistortionBlur()
		{
		}

		// Token: 0x040404C0 RID: 263360
		[Token(Token = "0x40404C0")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public LensDistortionBlur.QualityPreset Quality;

		// Token: 0x040404C1 RID: 263361
		[Token(Token = "0x40404C1")]
		[FieldOffset(Offset = "0x2C")]
		[Range(2f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		// Token: 0x040404C2 RID: 263362
		[Token(Token = "0x40404C2")]
		[FieldOffset(Offset = "0x30")]
		[Range(-2f, 2f)]
		[Tooltip("Spherical distortion factor.")]
		public float Distortion;

		// Token: 0x040404C3 RID: 263363
		[Token(Token = "0x40404C3")]
		[FieldOffset(Offset = "0x34")]
		[Range(-2f, 2f)]
		[Tooltip("Cubic distortion factor.")]
		public float CubicDistortion;

		// Token: 0x040404C4 RID: 263364
		[Token(Token = "0x40404C4")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.01f, 2f)]
		[Tooltip("Helps avoid screen streching on borders when working with heavy distortions.")]
		public float Scale;

		// Token: 0x02007CF0 RID: 31984
		[Token(Token = "0x2007CF0")]
		public enum QualityPreset
		{
			// Token: 0x040404C6 RID: 263366
			[Token(Token = "0x40404C6")]
			Low = 4,
			// Token: 0x040404C7 RID: 263367
			[Token(Token = "0x40404C7")]
			Medium = 8,
			// Token: 0x040404C8 RID: 263368
			[Token(Token = "0x40404C8")]
			High = 12,
			// Token: 0x040404C9 RID: 263369
			[Token(Token = "0x40404C9")]
			Custom
		}
	}
}
