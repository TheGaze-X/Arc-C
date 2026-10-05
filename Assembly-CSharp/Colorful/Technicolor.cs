using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D0B RID: 32011
	[Token(Token = "0x2007D0B")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/technicolor.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Technicolor")]
	public class Technicolor : BaseEffect
	{
		// Token: 0x0602CA5C RID: 182876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA5C")]
		[Address(RVA = "0x2883070", Offset = "0x2881C70", VA = "0x182883070", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA5D RID: 182877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA5D")]
		[Address(RVA = "0x2883040", Offset = "0x2881C40", VA = "0x182883040", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA5E RID: 182878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA5E")]
		[Address(RVA = "0x2883240", Offset = "0x2881E40", VA = "0x182883240")]
		public Technicolor()
		{
		}

		// Token: 0x04040557 RID: 263511
		[Token(Token = "0x4040557")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 8f)]
		public float Exposure;

		// Token: 0x04040558 RID: 263512
		[Token(Token = "0x4040558")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 Balance;

		// Token: 0x04040559 RID: 263513
		[Token(Token = "0x4040559")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
