using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD7 RID: 31959
	[Token(Token = "0x2007CD7")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/directional-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Directional Blur")]
	public class DirectionalBlur : BaseEffect
	{
		// Token: 0x0602C9D0 RID: 182736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D0")]
		[Address(RVA = "0x287B280", Offset = "0x2879E80", VA = "0x18287B280", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9D1 RID: 182737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9D1")]
		[Address(RVA = "0x287B250", Offset = "0x2879E50", VA = "0x18287B250", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9D2 RID: 182738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D2")]
		[Address(RVA = "0x287B3E0", Offset = "0x2879FE0", VA = "0x18287B3E0")]
		public DirectionalBlur()
		{
		}

		// Token: 0x04040448 RID: 263240
		[Token(Token = "0x4040448")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public DirectionalBlur.QualityPreset Quality;

		// Token: 0x04040449 RID: 263241
		[Token(Token = "0x4040449")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 16f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		// Token: 0x0404044A RID: 263242
		[Token(Token = "0x404044A")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 5f)]
		[Tooltip("Blur strength (distance).")]
		public float Strength;

		// Token: 0x0404044B RID: 263243
		[Token(Token = "0x404044B")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Blur direction in radians.")]
		public float Angle;

		// Token: 0x02007CD8 RID: 31960
		[Token(Token = "0x2007CD8")]
		public enum QualityPreset
		{
			// Token: 0x0404044D RID: 263245
			[Token(Token = "0x404044D")]
			Low = 2,
			// Token: 0x0404044E RID: 263246
			[Token(Token = "0x404044E")]
			Medium = 4,
			// Token: 0x0404044F RID: 263247
			[Token(Token = "0x404044F")]
			High = 6,
			// Token: 0x04040450 RID: 263248
			[Token(Token = "0x4040450")]
			Custom
		}
	}
}
