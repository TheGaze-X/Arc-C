using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CC8 RID: 31944
	[Token(Token = "0x2007CC8")]
	[AddComponentMenu("Colorful FX/Blur Effects/Bilateral Gaussian Blur")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/bilateral-gaussian-blur.html")]
	[ExecuteInEditMode]
	public class BilateralGaussianBlur : BaseEffect
	{
		// Token: 0x0602C9A5 RID: 182693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A5")]
		[Address(RVA = "0x2879460", Offset = "0x2878060", VA = "0x182879460", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0602C9A6 RID: 182694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A6")]
		[Address(RVA = "0x2878FE0", Offset = "0x2877BE0", VA = "0x182878FE0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9A7 RID: 182695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A7")]
		[Address(RVA = "0x28791F0", Offset = "0x2877DF0", VA = "0x1828791F0", Slot = "8")]
		protected virtual void OnePassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9A8 RID: 182696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9A8")]
		[Address(RVA = "0x2878B90", Offset = "0x2877790", VA = "0x182878B90", Slot = "9")]
		protected virtual void MultiPassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9A9 RID: 182697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9A9")]
		[Address(RVA = "0x2878B60", Offset = "0x2877760", VA = "0x182878B60", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9AA RID: 182698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9AA")]
		[Address(RVA = "0x28794D0", Offset = "0x28780D0", VA = "0x1828794D0")]
		public BilateralGaussianBlur()
		{
		}

		// Token: 0x040403F8 RID: 263160
		[Token(Token = "0x40403F8")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 10f)]
		[Tooltip("Add more passes to get a smoother blur. Beware that each pass will slow down the effect.")]
		public int Passes;

		// Token: 0x040403F9 RID: 263161
		[Token(Token = "0x40403F9")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.04f, 1f)]
		[Tooltip("Adjusts the blur \"sharpness\" around edges")]
		public float Threshold;

		// Token: 0x040403FA RID: 263162
		[Token(Token = "0x40403FA")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
