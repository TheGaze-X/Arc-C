using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public struct SteamNetConnectionInfo_t
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001F")]
		public string m_szEndDebug
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x4F0E780", Offset = "0x4F0D380", VA = "0x184F0E780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x4F0E840", Offset = "0x4F0D440", VA = "0x184F0E840")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000020")]
		public string m_szConnectionDescription
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x4F0E6E0", Offset = "0x4F0D2E0", VA = "0x184F0E6E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x4F0E820", Offset = "0x4F0D420", VA = "0x184F0E820")]
			set
			{
			}
		}

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetworkingIdentity m_identityRemote;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x88")]
		public long m_nUserData;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x90")]
		public HSteamListenSocket m_hListenSocket;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x98")]
		public SteamNetworkingIPAddr m_addrRemote;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0xA8")]
		public ushort m__pad1;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0xAC")]
		public SteamNetworkingPOPID m_idPOPRemote;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0xB0")]
		public SteamNetworkingPOPID m_idPOPRelay;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0xB4")]
		public ESteamNetworkingConnectionState m_eState;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0xB8")]
		public int m_eEndReason;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0xC0")]
		private byte[] m_szEndDebug_;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0xC8")]
		private byte[] m_szConnectionDescription_;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0xD0")]
		public int m_nFlags;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0xD8")]
		public uint[] reserved;
	}
}
