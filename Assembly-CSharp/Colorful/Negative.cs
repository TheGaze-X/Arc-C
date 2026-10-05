using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF8 RID: 31992
	[Token(Token = "0x2007CF8")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/negative.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Negative")]
	public class Negative : BaseEffect
	{
		// Token: 0x0602CA2F RID: 182831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2F")]
		[Address(RVA = "0x2880F30", Offset = "0x287FB30", VA = "0x182880F30", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA30 RID: 182832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA30")]
		[Address(RVA = "0x2880F00", Offset = "0x287FB00", VA = "0x182880F00", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA31 RID: 182833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA31")]
		[Address(RVA = "0x2879610", Offset = "0x2878210", VA = "0x182879610")]
		public Negative()
		{
		}

		// Token: 0x04040509 RID: 263433
		[Token(Token = "0x4040509")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
