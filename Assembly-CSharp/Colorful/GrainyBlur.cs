using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE6 RID: 31974
	[Token(Token = "0x2007CE6")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/grainy-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Grainy Blur")]
	public class GrainyBlur : BaseEffect
	{
		// Token: 0x0602C9FA RID: 182778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9FA")]
		[Address(RVA = "0x287D700", Offset = "0x287C300", VA = "0x18287D700", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9FB RID: 182779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9FB")]
		[Address(RVA = "0x287D6D0", Offset = "0x287C2D0", VA = "0x18287D6D0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9FC RID: 182780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9FC")]
		[Address(RVA = "0x287D840", Offset = "0x287C440", VA = "0x18287D840")]
		public GrainyBlur()
		{
		}

		// Token: 0x04040490 RID: 263312
		[Token(Token = "0x4040490")]
		[FieldOffset(Offset = "0x28")]
		[ColorMin(0f)]
		[Tooltip("Blur radius.")]
		public float Radius;

		// Token: 0x04040491 RID: 263313
		[Token(Token = "0x4040491")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;
	}
}
