using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D13 RID: 32019
	[Token(Token = "0x2007D13")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/white-balance.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/White Balance")]
	public class WhiteBalance : BaseEffect
	{
		// Token: 0x0602CA6F RID: 182895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA6F")]
		[Address(RVA = "0x2883CD0", Offset = "0x28828D0", VA = "0x182883CD0", Slot = "8")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0602CA70 RID: 182896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA70")]
		[Address(RVA = "0x2883C00", Offset = "0x2882800", VA = "0x182883C00", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA71 RID: 182897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA71")]
		[Address(RVA = "0x2883BD0", Offset = "0x28827D0", VA = "0x182883BD0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA72 RID: 182898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA72")]
		[Address(RVA = "0x2883D10", Offset = "0x2882910", VA = "0x182883D10")]
		public WhiteBalance()
		{
		}

		// Token: 0x04040589 RID: 263561
		[Token(Token = "0x4040589")]
		[FieldOffset(Offset = "0x28")]
		[ColorUsage(false)]
		[Tooltip("Reference white point or midtone value.")]
		public Color White;

		// Token: 0x0404058A RID: 263562
		[Token(Token = "0x404058A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Algorithm used.")]
		public WhiteBalance.BalanceMode Mode;

		// Token: 0x02007D14 RID: 32020
		[Token(Token = "0x2007D14")]
		public enum BalanceMode
		{
			// Token: 0x0404058C RID: 263564
			[Token(Token = "0x404058C")]
			Simple,
			// Token: 0x0404058D RID: 263565
			[Token(Token = "0x404058D")]
			Complex
		}
	}
}
