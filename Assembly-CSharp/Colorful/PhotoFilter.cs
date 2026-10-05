using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CFB RID: 31995
	[Token(Token = "0x2007CFB")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/photo-filter.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Photo Filter")]
	public class PhotoFilter : BaseEffect
	{
		// Token: 0x0602CA36 RID: 182838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA36")]
		[Address(RVA = "0x2881280", Offset = "0x287FE80", VA = "0x182881280", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA37 RID: 182839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA37")]
		[Address(RVA = "0x2881250", Offset = "0x287FE50", VA = "0x182881250", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA38 RID: 182840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA38")]
		[Address(RVA = "0x28813B0", Offset = "0x287FFB0", VA = "0x1828813B0")]
		public PhotoFilter()
		{
		}

		// Token: 0x04040512 RID: 263442
		[Token(Token = "0x4040512")]
		[FieldOffset(Offset = "0x28")]
		[ColorUsage(false)]
		[Tooltip("Lens filter color.")]
		public Color Color;

		// Token: 0x04040513 RID: 263443
		[Token(Token = "0x4040513")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Density;
	}
}
