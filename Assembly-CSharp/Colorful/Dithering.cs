using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD9 RID: 31961
	[Token(Token = "0x2007CD9")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Dithering")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/dithering.html")]
	public class Dithering : BaseEffect
	{
		// Token: 0x0602C9D3 RID: 182739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D3")]
		[Address(RVA = "0x287B430", Offset = "0x287A030", VA = "0x18287B430", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9D4 RID: 182740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9D4")]
		[Address(RVA = "0x287B400", Offset = "0x287A000", VA = "0x18287B400", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9D5 RID: 182741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D5")]
		[Address(RVA = "0x287B640", Offset = "0x287A240", VA = "0x18287B640")]
		public Dithering()
		{
		}

		// Token: 0x04040451 RID: 263249
		[Token(Token = "0x4040451")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Show the original picture under the dithering pass.")]
		public bool ShowOriginal;

		// Token: 0x04040452 RID: 263250
		[Token(Token = "0x4040452")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Convert the original render to black & white.")]
		public bool ConvertToGrayscale;

		// Token: 0x04040453 RID: 263251
		[Token(Token = "0x4040453")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the luminosity.")]
		public float RedLuminance;

		// Token: 0x04040454 RID: 263252
		[Token(Token = "0x4040454")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Amount of green to contribute to the luminosity.")]
		public float GreenLuminance;

		// Token: 0x04040455 RID: 263253
		[Token(Token = "0x4040455")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Amount of blue to contribute to the luminosity.")]
		public float BlueLuminance;

		// Token: 0x04040456 RID: 263254
		[Token(Token = "0x4040456")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x04040457 RID: 263255
		[Token(Token = "0x4040457")]
		[FieldOffset(Offset = "0x40")]
		protected Texture2D m_DitherPattern;
	}
}
