using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CD3 RID: 31955
	[Token(Token = "0x2007CD3")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/contrast-gain.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Contrast Gain")]
	public class ContrastGain : BaseEffect
	{
		// Token: 0x0602C9C4 RID: 182724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C4")]
		[Address(RVA = "0x287A810", Offset = "0x2879410", VA = "0x18287A810", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9C5 RID: 182725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9C5")]
		[Address(RVA = "0x287A7E0", Offset = "0x28793E0", VA = "0x18287A7E0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9C6 RID: 182726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9C6")]
		[Address(RVA = "0x2879610", Offset = "0x2878210", VA = "0x182879610")]
		public ContrastGain()
		{
		}

		// Token: 0x04040438 RID: 263224
		[Token(Token = "0x4040438")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.001f, 2f)]
		[Tooltip("Steepness of the contrast curve. 1 is linear, no contrast change.")]
		public float Gain;
	}
}
