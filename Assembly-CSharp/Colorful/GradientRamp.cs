using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE4 RID: 31972
	[Token(Token = "0x2007CE4")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/gradient-ramp.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Gradient Ramp")]
	public class GradientRamp : BaseEffect
	{
		// Token: 0x0602C9F1 RID: 182769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F1")]
		[Address(RVA = "0x287D570", Offset = "0x287C170", VA = "0x18287D570", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9F2 RID: 182770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9F2")]
		[Address(RVA = "0x287D540", Offset = "0x287C140", VA = "0x18287D540", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9F3 RID: 182771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F3")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public GradientRamp()
		{
		}

		// Token: 0x0404048B RID: 263307
		[Token(Token = "0x404048B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Texture used to remap the pixels luminosity.")]
		public Texture RampTexture;

		// Token: 0x0404048C RID: 263308
		[Token(Token = "0x404048C")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
