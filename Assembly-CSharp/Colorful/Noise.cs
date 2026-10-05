using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF9 RID: 31993
	[Token(Token = "0x2007CF9")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/noise.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Noise")]
	public class Noise : BaseEffect
	{
		// Token: 0x0602CA32 RID: 182834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA32")]
		[Address(RVA = "0x28811D0", Offset = "0x287FDD0", VA = "0x1828811D0", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x0602CA33 RID: 182835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA33")]
		[Address(RVA = "0x2881080", Offset = "0x287FC80", VA = "0x182881080", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA34 RID: 182836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA34")]
		[Address(RVA = "0x2881050", Offset = "0x287FC50", VA = "0x182881050", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA35 RID: 182837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA35")]
		[Address(RVA = "0x2881230", Offset = "0x287FE30", VA = "0x182881230")]
		public Noise()
		{
		}

		// Token: 0x0404050A RID: 263434
		[Token(Token = "0x404050A")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Black & white or colored noise.")]
		public Noise.ColorMode Mode;

		// Token: 0x0404050B RID: 263435
		[Token(Token = "0x404050B")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Automatically increment the seed to animate the noise.")]
		public bool Animate;

		// Token: 0x0404050C RID: 263436
		[Token(Token = "0x404050C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("A number used to initialize the noise generator.")]
		public float Seed;

		// Token: 0x0404050D RID: 263437
		[Token(Token = "0x404050D")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Strength used to apply the noise. 0 means no noise at all, 1 is full noise.")]
		public float Strength;

		// Token: 0x0404050E RID: 263438
		[Token(Token = "0x404050E")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Reduce the noise visibility in luminous areas.")]
		public float LumContribution;

		// Token: 0x02007CFA RID: 31994
		[Token(Token = "0x2007CFA")]
		public enum ColorMode
		{
			// Token: 0x04040510 RID: 263440
			[Token(Token = "0x4040510")]
			Monochrome,
			// Token: 0x04040511 RID: 263441
			[Token(Token = "0x4040511")]
			RGB
		}
	}
}
