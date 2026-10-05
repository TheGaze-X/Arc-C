using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	[Serializable]
	public struct SteamNetworkingMessage_t
	{
		// Token: 0x06000B17 RID: 2839 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x4F0F7E0", Offset = "0x4F0E3E0", VA = "0x184F0F7E0")]
		public void Release()
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x4F0B450", Offset = "0x4F0A050", VA = "0x184F0B450")]
		public static void Release(IntPtr pointer)
		{
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0000992C File Offset: 0x00007B2C
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4F0F670", Offset = "0x4F0E270", VA = "0x184F0F670")]
		public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer)
		{
			return default(SteamNetworkingMessage_t);
		}

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_pData;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x8")]
		public int m_cbSize;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0xC")]
		public HSteamNetConnection m_conn;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x10")]
		public SteamNetworkingIdentity m_identityPeer;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x98")]
		public long m_nConnUserData;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0xA0")]
		public SteamNetworkingMicroseconds m_usecTimeReceived;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0xA8")]
		public long m_nMessageNumber;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0xB0")]
		public IntPtr m_pfnFreeData;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0xB8")]
		internal IntPtr m_pfnRelease;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0xC0")]
		public int m_nChannel;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0xC4")]
		public int m_nFlags;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0xC8")]
		public long m_nUserData;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0xD0")]
		public ushort m_idxLane;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0xD2")]
		public ushort _pad1__;
	}
}
