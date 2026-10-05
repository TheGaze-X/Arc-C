using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D06 RID: 32006
	[Token(Token = "0x2007D06")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/sharpen.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Sharpen")]
	public class Sharpen : BaseEffect
	{
		// Token: 0x0602CA4E RID: 182862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA4E")]
		[Address(RVA = "0x28822C0", Offset = "0x2880EC0", VA = "0x1828822C0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA4F RID: 182863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA4F")]
		[Address(RVA = "0x2882290", Offset = "0x2880E90", VA = "0x182882290", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA50 RID: 182864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA50")]
		[Address(RVA = "0x28824C0", Offset = "0x28810C0", VA = "0x1828824C0")]
		public Sharpen()
		{
		}

		// Token: 0x0404053D RID: 263485
		[Token(Token = "0x404053D")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Sharpening algorithm to use.")]
		public Sharpen.Algorithm Mode;

		// Token: 0x0404053E RID: 263486
		[Token(Token = "0x404053E")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		[Tooltip("Sharpening Strength.")]
		public float Strength;

		// Token: 0x0404053F RID: 263487
		[Token(Token = "0x404053F")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Limits the amount of sharpening a pixel will receive.")]
		public float Clamp;

		// Token: 0x02007D07 RID: 32007
		[Token(Token = "0x2007D07")]
		public enum Algorithm
		{
			// Token: 0x04040541 RID: 263489
			[Token(Token = "0x4040541")]
			TypeA,
			// Token: 0x04040542 RID: 263490
			[Token(Token = "0x4040542")]
			TypeB
		}
	}
}
