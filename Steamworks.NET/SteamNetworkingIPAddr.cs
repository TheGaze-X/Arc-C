using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	[Serializable]
	public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
	{
		// Token: 0x06000B0A RID: 2826 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x4F09830", Offset = "0x4F08430", VA = "0x184F09830")]
		public void Clear()
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0000986C File Offset: 0x00007A6C
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x4F09DB0", Offset = "0x4F089B0", VA = "0x184F09DB0")]
		public bool IsIPv6AllZeros()
		{
			return default(bool);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x4F0A290", Offset = "0x4F08E90", VA = "0x184F0A290")]
		public void SetIPv6(byte[] ipv6, ushort nPort)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x4F0A0C0", Offset = "0x4F08CC0", VA = "0x184F0A0C0")]
		public void SetIPv4(uint nIP, ushort nPort)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00009884 File Offset: 0x00007A84
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x4F09CD0", Offset = "0x4F088D0", VA = "0x184F09CD0")]
		public bool IsIPv4()
		{
			return default(bool);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0000989C File Offset: 0x00007A9C
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x4F099E0", Offset = "0x4F085E0", VA = "0x184F099E0")]
		public uint GetIPv4()
		{
			return 0U;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x4F0A1B0", Offset = "0x4F08DB0", VA = "0x184F0A1B0")]
		public void SetIPv6LocalHost(ushort nPort = 0)
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000098B4 File Offset: 0x00007AB4
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x4F09E90", Offset = "0x4F08A90", VA = "0x184F09E90")]
		public bool IsLocalHost()
		{
			return default(bool);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x4F0EAA0", Offset = "0x4F0D6A0", VA = "0x184F0EAA0")]
		public void ToString(out string buf, bool bWithPort)
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000098CC File Offset: 0x00007ACC
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x4F0E880", Offset = "0x4F0D480", VA = "0x184F0E880")]
		public bool ParseString(string pszStr)
		{
			return default(bool);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000098E4 File Offset: 0x00007AE4
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x4F09AC0", Offset = "0x4F086C0", VA = "0x184F09AC0", Slot = "4")]
		public bool Equals(SteamNetworkingIPAddr x)
		{
			return default(bool);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000098FC File Offset: 0x00007AFC
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x4F09900", Offset = "0x4F08500", VA = "0x184F09900")]
		public ESteamNetworkingFakeIPType GetFakeIPType()
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00009914 File Offset: 0x00007B14
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x4F0E860", Offset = "0x4F0D460", VA = "0x184F0E860")]
		public bool IsFakeIP()
		{
			return default(bool);
		}

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x0")]
		public byte[] m_ipv6;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x8")]
		public ushort m_port;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		public const int k_cchMaxString = 48;
	}
}
