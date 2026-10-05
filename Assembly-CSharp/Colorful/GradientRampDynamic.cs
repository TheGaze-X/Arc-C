using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE5 RID: 31973
	[Token(Token = "0x2007CE5")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/gradient-ramp-dynamic.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Gradient Ramp (Dynamic)")]
	public class GradientRampDynamic : BaseEffect
	{
		// Token: 0x0602C9F4 RID: 182772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F4")]
		[Address(RVA = "0x287D350", Offset = "0x287BF50", VA = "0x18287D350", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0602C9F5 RID: 182773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F5")]
		[Address(RVA = "0x287D100", Offset = "0x287BD00", VA = "0x18287D100", Slot = "8")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0602C9F6 RID: 182774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F6")]
		[Address(RVA = "0x287D380", Offset = "0x287BF80", VA = "0x18287D380")]
		public void UpdateGradientCache()
		{
		}

		// Token: 0x0602C9F7 RID: 182775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F7")]
		[Address(RVA = "0x287CFC0", Offset = "0x287BBC0", VA = "0x18287CFC0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9F8 RID: 182776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9F8")]
		[Address(RVA = "0x287CF90", Offset = "0x287BB90", VA = "0x18287CF90", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9F9 RID: 182777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9F9")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public GradientRampDynamic()
		{
		}

		// Token: 0x0404048D RID: 263309
		[Token(Token = "0x404048D")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Gradient used to remap the pixels luminosity.")]
		public Gradient Ramp;

		// Token: 0x0404048E RID: 263310
		[Token(Token = "0x404048E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x0404048F RID: 263311
		[Token(Token = "0x404048F")]
		[FieldOffset(Offset = "0x38")]
		protected Texture2D m_RampTexture;
	}
}
