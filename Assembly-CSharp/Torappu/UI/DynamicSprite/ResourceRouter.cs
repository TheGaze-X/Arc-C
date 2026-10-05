using System;
using Il2CppDummyDll;

namespace Torappu.UI.DynamicSprite
{
	// Token: 0x02005A50 RID: 23120
	[Token(Token = "0x2005A50")]
	public static class ResourceRouter
	{
		// Token: 0x06021A7B RID: 137851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A7B")]
		[Address(RVA = "0x1C1B1E0", Offset = "0x1C19DE0", VA = "0x181C1B1E0")]
		public static string SpriteHolderResPath(string holderName)
		{
			return null;
		}

		// Token: 0x0402E04E RID: 188494
		[Token(Token = "0x402E04E")]
		public const string PACKING_TAG_PREFIX = "[PACK]";

		// Token: 0x0402E04F RID: 188495
		[Token(Token = "0x402E04F")]
		public const string SPRITE_ASSET_ROOT_PATH = "Assets/Torappu/Arts/UI/PackUI";

		// Token: 0x0402E050 RID: 188496
		[Token(Token = "0x402E050")]
		public const string SPRITE_AB_ROOT_PATH = "Arts/UI/[UC]Packed";
	}
}
