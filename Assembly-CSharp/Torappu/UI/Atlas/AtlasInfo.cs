using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C31 RID: 23601
	[Token(Token = "0x2005C31")]
	[Serializable]
	public class AtlasInfo : IHotfixable
	{
		// Token: 0x06022354 RID: 140116 RVA: 0x000BCB08 File Offset: 0x000BAD08
		[Token(Token = "0x6022354")]
		[Address(RVA = "0x1CA1800", Offset = "0x1CA0400", VA = "0x181CA1800")]
		public SpriteRenderData CreateRenderData(AtlasSprite sprite)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06022355 RID: 140117 RVA: 0x000BCB20 File Offset: 0x000BAD20
		[Token(Token = "0x6022355")]
		[Address(RVA = "0x1CA1770", Offset = "0x1CA0370", VA = "0x181CA1770")]
		public static int ConvertAtlasSize(AtlasSize size)
		{
			return 0;
		}

		// Token: 0x06022356 RID: 140118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022356")]
		[Address(RVA = "0x1CA1950", Offset = "0x1CA0550", VA = "0x181CA1950")]
		public AtlasInfo()
		{
		}

		// Token: 0x0402EEE5 RID: 192229
		[Token(Token = "0x402EEE5")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0402EEE6 RID: 192230
		[Token(Token = "0x402EEE6")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D texture;

		// Token: 0x0402EEE7 RID: 192231
		[Token(Token = "0x402EEE7")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D alpha;

		// Token: 0x0402EEE8 RID: 192232
		[Token(Token = "0x402EEE8")]
		[FieldOffset(Offset = "0x28")]
		public int size;

		// Token: 0x0402EEE9 RID: 192233
		[Token(Token = "0x402EEE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateRenderData;

		// Token: 0x0402EEEA RID: 192234
		[Token(Token = "0x402EEEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConvertAtlasSize;

		// Token: 0x0402EEEB RID: 192235
		[Token(Token = "0x402EEEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
