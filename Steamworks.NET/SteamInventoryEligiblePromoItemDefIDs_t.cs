using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[CallbackIdentity(4703)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		public const int k_iCallback = 4703;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0xC")]
		public int m_numEligiblePromoItemDefs;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bCachedData;
	}
}
