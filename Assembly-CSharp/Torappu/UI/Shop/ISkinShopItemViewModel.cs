using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B67 RID: 23399
	[Token(Token = "0x2005B67")]
	public interface ISkinShopItemViewModel
	{
		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06021F75 RID: 139125
		[Token(Token = "0x17004F7F")]
		string itemId { [Token(Token = "0x6021F75")] get; }

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x06021F76 RID: 139126
		[Token(Token = "0x17004F80")]
		int slotId { [Token(Token = "0x6021F76")] get; }

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x06021F77 RID: 139127
		[Token(Token = "0x17004F81")]
		bool isAchieved { [Token(Token = "0x6021F77")] get; }

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06021F78 RID: 139128
		[Token(Token = "0x17004F82")]
		SkinShopItemType itemType { [Token(Token = "0x6021F78")] get; }

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06021F79 RID: 139129
		[Token(Token = "0x17004F83")]
		int remainCount { [Token(Token = "0x6021F79")] get; }
	}
}
