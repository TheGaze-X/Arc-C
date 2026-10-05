using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[CallbackIdentity(1281)]
	public struct SteamRelayNetworkStatus_t
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000B")]
		public string m_debugMsg
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x4ED76A0", Offset = "0x4ED62A0", VA = "0x184ED76A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x4F10110", Offset = "0x4F0ED10", VA = "0x184F10110")]
			set
			{
			}
		}

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		public const int k_iCallback = 1281;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingAvailability m_eAvail;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x4")]
		public int m_bPingMeasurementInProgress;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x8")]
		public ESteamNetworkingAvailability m_eAvailNetworkConfig;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0xC")]
		public ESteamNetworkingAvailability m_eAvailAnyRelay;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_debugMsg_;
	}
}
