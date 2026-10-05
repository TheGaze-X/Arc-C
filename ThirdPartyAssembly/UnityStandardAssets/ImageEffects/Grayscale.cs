using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x51E3390", Offset = "0x51E1F90", VA = "0x1851E3390")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Grayscale()
		{
		}

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;
	}
}
