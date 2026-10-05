using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D00 RID: 32000
	[Token(Token = "0x2007D00")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/radial-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Radial Blur")]
	public class RadialBlur : BaseEffect
	{
		// Token: 0x0602CA42 RID: 182850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA42")]
		[Address(RVA = "0x2881A90", Offset = "0x2880690", VA = "0x182881A90", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA43 RID: 182851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA43")]
		[Address(RVA = "0x2881A60", Offset = "0x2880660", VA = "0x182881A60", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA44 RID: 182852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA44")]
		[Address(RVA = "0x2881C60", Offset = "0x2880860", VA = "0x182881C60")]
		public RadialBlur()
		{
		}

		// Token: 0x04040521 RID: 263457
		[Token(Token = "0x4040521")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Blur strength.")]
		public float Strength;

		// Token: 0x04040522 RID: 263458
		[Token(Token = "0x4040522")]
		[FieldOffset(Offset = "0x2C")]
		[Range(2f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		// Token: 0x04040523 RID: 263459
		[Token(Token = "0x4040523")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Focus point.")]
		public Vector2 Center;

		// Token: 0x04040524 RID: 263460
		[Token(Token = "0x4040524")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public RadialBlur.QualityPreset Quality;

		// Token: 0x04040525 RID: 263461
		[Token(Token = "0x4040525")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		// Token: 0x04040526 RID: 263462
		[Token(Token = "0x4040526")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		// Token: 0x04040527 RID: 263463
		[Token(Token = "0x4040527")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Should the effect be applied like a vignette ?")]
		public bool EnableVignette;

		// Token: 0x02007D01 RID: 32001
		[Token(Token = "0x2007D01")]
		public enum QualityPreset
		{
			// Token: 0x04040529 RID: 263465
			[Token(Token = "0x4040529")]
			Low = 4,
			// Token: 0x0404052A RID: 263466
			[Token(Token = "0x404052A")]
			Medium = 8,
			// Token: 0x0404052B RID: 263467
			[Token(Token = "0x404052B")]
			High = 12,
			// Token: 0x0404052C RID: 263468
			[Token(Token = "0x404052C")]
			Custom
		}
	}
}
