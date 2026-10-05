using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[CallbackIdentity(4704)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		public const int k_iCallback = 4704;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulTransID;
	}
}
