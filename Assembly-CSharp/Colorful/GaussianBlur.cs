using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CDF RID: 31967
	[Token(Token = "0x2007CDF")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/gaussian-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Gaussian Blur")]
	public class GaussianBlur : BaseEffect
	{
		// Token: 0x0602C9E2 RID: 182754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E2")]
		[Address(RVA = "0x287C480", Offset = "0x287B080", VA = "0x18287C480", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9E3 RID: 182755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E3")]
		[Address(RVA = "0x287C680", Offset = "0x287B280", VA = "0x18287C680", Slot = "8")]
		protected virtual void OnePassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9E4 RID: 182756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E4")]
		[Address(RVA = "0x287C040", Offset = "0x287AC40", VA = "0x18287C040", Slot = "9")]
		protected virtual void MultiPassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9E5 RID: 182757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9E5")]
		[Address(RVA = "0x287C010", Offset = "0x287AC10", VA = "0x18287C010", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9E6 RID: 182758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E6")]
		[Address(RVA = "0x287C930", Offset = "0x287B530", VA = "0x18287C930")]
		public GaussianBlur()
		{
		}

		// Token: 0x04040470 RID: 263280
		[Token(Token = "0x4040470")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 10f)]
		[Tooltip("Amount of blurring pass to apply.")]
		public int Passes;

		// Token: 0x04040471 RID: 263281
		[Token(Token = "0x4040471")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 16f)]
		[Tooltip("Downscales the result for faster processing or heavier blur.")]
		public float Downscaling;

		// Token: 0x04040472 RID: 263282
		[Token(Token = "0x4040472")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
