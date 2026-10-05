using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x51E3730", Offset = "0x51E2330", VA = "0x1851E3730")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x51E36D0", Offset = "0x51E22D0", VA = "0x1851E36D0")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x51E3660", Offset = "0x51E2260", VA = "0x1851E3660")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ImageEffects()
		{
		}
	}
}
