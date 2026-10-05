using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE7 RID: 31975
	[Token(Token = "0x2007CE7")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/grayscale.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Grayscale")]
	public class Grayscale : BaseEffect
	{
		// Token: 0x0602C9FD RID: 182781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9FD")]
		[Address(RVA = "0x287D890", Offset = "0x287C490", VA = "0x18287D890", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9FE RID: 182782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9FE")]
		[Address(RVA = "0x287D860", Offset = "0x287C460", VA = "0x18287D860", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9FF RID: 182783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9FF")]
		[Address(RVA = "0x287D9B0", Offset = "0x287C5B0", VA = "0x18287D9B0")]
		public Grayscale()
		{
		}

		// Token: 0x04040492 RID: 263314
		[Token(Token = "0x4040492")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the luminosity.")]
		public float RedLuminance;

		// Token: 0x04040493 RID: 263315
		[Token(Token = "0x4040493")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Amount of green to contribute to the luminosity.")]
		public float GreenLuminance;

		// Token: 0x04040494 RID: 263316
		[Token(Token = "0x4040494")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Amount of blue to contribute to the luminosity.")]
		public float BlueLuminance;

		// Token: 0x04040495 RID: 263317
		[Token(Token = "0x4040495")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
