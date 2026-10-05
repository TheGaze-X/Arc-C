using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		public const int k_iCallback = 152;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bAuthorized;
	}
}
