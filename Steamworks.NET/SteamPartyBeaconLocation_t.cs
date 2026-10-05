using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public struct SteamPartyBeaconLocation_t
	{
		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x0")]
		public ESteamPartyBeaconLocationType m_eType;

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulLocationID;
	}
}
