using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D03 RID: 32003
	[Token(Token = "0x2007D03")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/s-curve-contrast.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/S-Curve Contrast")]
	public class SCurveContrast : BaseEffect
	{
		// Token: 0x0602CA48 RID: 182856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA48")]
		[Address(RVA = "0x2881CD0", Offset = "0x28808D0", VA = "0x182881CD0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA49 RID: 182857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA49")]
		[Address(RVA = "0x2881CA0", Offset = "0x28808A0", VA = "0x182881CA0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA4A RID: 182858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA4A")]
		[Address(RVA = "0x2881E70", Offset = "0x2880A70", VA = "0x182881E70")]
		public SCurveContrast()
		{
		}

		// Token: 0x0404052F RID: 263471
		[Token(Token = "0x404052F")]
		[FieldOffset(Offset = "0x28")]
		public float RedSteepness;

		// Token: 0x04040530 RID: 263472
		[Token(Token = "0x4040530")]
		[FieldOffset(Offset = "0x2C")]
		public float RedGamma;

		// Token: 0x04040531 RID: 263473
		[Token(Token = "0x4040531")]
		[FieldOffset(Offset = "0x30")]
		public float GreenSteepness;

		// Token: 0x04040532 RID: 263474
		[Token(Token = "0x4040532")]
		[FieldOffset(Offset = "0x34")]
		public float GreenGamma;

		// Token: 0x04040533 RID: 263475
		[Token(Token = "0x4040533")]
		[FieldOffset(Offset = "0x38")]
		public float BlueSteepness;

		// Token: 0x04040534 RID: 263476
		[Token(Token = "0x4040534")]
		[FieldOffset(Offset = "0x3C")]
		public float BlueGamma;
	}
}
