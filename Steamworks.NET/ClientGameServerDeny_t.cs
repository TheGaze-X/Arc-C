using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		public const int k_iCallback = 113;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
}
