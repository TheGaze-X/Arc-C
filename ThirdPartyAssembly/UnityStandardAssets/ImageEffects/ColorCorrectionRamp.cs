using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x51DC500", Offset = "0x51DB100", VA = "0x1851DC500")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ColorCorrectionRamp()
		{
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;
	}
}
