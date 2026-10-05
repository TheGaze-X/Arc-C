using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CEA RID: 31978
	[Token(Token = "0x2007CEA")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/hue-focus.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Hue Focus")]
	public class HueFocus : BaseEffect
	{
		// Token: 0x0602CA05 RID: 182789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA05")]
		[Address(RVA = "0x287DEA0", Offset = "0x287CAA0", VA = "0x18287DEA0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA06 RID: 182790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA06")]
		[Address(RVA = "0x287DE70", Offset = "0x287CA70", VA = "0x18287DE70", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA07 RID: 182791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA07")]
		[Address(RVA = "0x287E020", Offset = "0x287CC20", VA = "0x18287E020")]
		public HueFocus()
		{
		}

		// Token: 0x0404049C RID: 263324
		[Token(Token = "0x404049C")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 360f)]
		[Tooltip("Center hue.")]
		public float Hue;

		// Token: 0x0404049D RID: 263325
		[Token(Token = "0x404049D")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 180f)]
		[Tooltip("Hue range to focus on.")]
		public float Range;

		// Token: 0x0404049E RID: 263326
		[Token(Token = "0x404049E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Makes the colored pixels more vibrant.")]
		public float Boost;

		// Token: 0x0404049F RID: 263327
		[Token(Token = "0x404049F")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Blending Factor.")]
		public float Amount;
	}
}
