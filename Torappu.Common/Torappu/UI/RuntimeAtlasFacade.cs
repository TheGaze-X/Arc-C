using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public static class RuntimeAtlasFacade
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x5532180", Offset = "0x5530D80", VA = "0x185532180")]
		public static bool PackToAtlas(int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00006FEC File Offset: 0x000051EC
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x5531FA0", Offset = "0x5530BA0", VA = "0x185531FA0")]
		public static bool IsSpriteForAtlas(Sprite sprite, Texture texture)
		{
			return default(bool);
		}

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		public const bool IS_SUPPORTED = true;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		public const int UI_IMAGE_BLOCK_ALIGNMENT = 4;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		private const float MAX_TEXTURE_OVERLAP = 5.00001f;
	}
}
