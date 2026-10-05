using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[CallbackIdentity(502)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		public const int k_iCallback = 502;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
}
