using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	[Serializable]
	public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x4F0A480", Offset = "0x4F09080", VA = "0x184F0A480")]
		public void Clear()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00009704 File Offset: 0x00007904
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x4F0AB20", Offset = "0x4F09720", VA = "0x184F0AB20")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x4F0F2F0", Offset = "0x4F0DEF0", VA = "0x184F0F2F0")]
		public void SetSteamID(CSteamID steamID)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0000971C File Offset: 0x0000791C
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x4F0ED30", Offset = "0x4F0D930", VA = "0x184F0ED30")]
		public CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x4F0B1B0", Offset = "0x4F09DB0", VA = "0x184F0B1B0")]
		public void SetSteamID64(ulong steamID)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00009734 File Offset: 0x00007934
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x4F0A890", Offset = "0x4F09490", VA = "0x184F0A890")]
		public ulong GetSteamID64()
		{
			return 0UL;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0000974C File Offset: 0x0000794C
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x4F0F3B0", Offset = "0x4F0DFB0", VA = "0x184F0F3B0")]
		public bool SetXboxPairwiseID(string pszString)
		{
			return default(bool);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x4F0EDE0", Offset = "0x4F0D9E0", VA = "0x184F0EDE0")]
		public string GetXboxPairwiseID()
		{
			return null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x4F0B090", Offset = "0x4F09C90", VA = "0x184F0B090")]
		public void SetPSNID(ulong id)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00009764 File Offset: 0x00007964
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x4F0A790", Offset = "0x4F09390", VA = "0x184F0A790")]
		public ulong GetPSNID()
		{
			return 0UL;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x4F0B120", Offset = "0x4F09D20", VA = "0x184F0B120")]
		public void SetStadiaID(ulong id)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0000977C File Offset: 0x0000797C
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x4F0A810", Offset = "0x4F09410", VA = "0x184F0A810")]
		public ulong GetStadiaID()
		{
			return 0UL;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x4F0F210", Offset = "0x4F0DE10", VA = "0x184F0F210")]
		public void SetIPAddr(SteamNetworkingIPAddr addr)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00009794 File Offset: 0x00007994
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x4F0ECE0", Offset = "0x4F0D8E0", VA = "0x184F0ECE0")]
		public SteamNetworkingIPAddr GetIPAddr()
		{
			return default(SteamNetworkingIPAddr);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x4F0AF70", Offset = "0x4F09B70", VA = "0x184F0AF70")]
		public void SetIPv4Addr(uint nIPv4, ushort nPort)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000097AC File Offset: 0x000079AC
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x4F0A710", Offset = "0x4F09310", VA = "0x184F0A710")]
		public uint GetIPv4()
		{
			return 0U;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000097C4 File Offset: 0x000079C4
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x4F0A500", Offset = "0x4F09100", VA = "0x184F0A500")]
		public ESteamNetworkingFakeIPType GetFakeIPType()
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000097DC File Offset: 0x000079DC
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x4F0EE70", Offset = "0x4F0DA70", VA = "0x184F0EE70")]
		public bool IsFakeIP()
		{
			return default(bool);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x4F0B010", Offset = "0x4F09C10", VA = "0x184F0B010")]
		public void SetLocalHost()
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000097F4 File Offset: 0x000079F4
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x4F0ABA0", Offset = "0x4F097A0", VA = "0x184F0ABA0")]
		public bool IsLocalHost()
		{
			return default(bool);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0000980C File Offset: 0x00007A0C
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x4F0F050", Offset = "0x4F0DC50", VA = "0x184F0F050")]
		public bool SetGenericString(string pszString)
		{
			return default(bool);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x4F0EC50", Offset = "0x4F0D850", VA = "0x184F0EC50")]
		public string GetGenericString()
		{
			return null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00009824 File Offset: 0x00007A24
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x4F0AD00", Offset = "0x4F09900", VA = "0x184F0AD00")]
		public bool SetGenericBytes(byte[] data, uint cbLen)
		{
			return default(bool);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x4F0EC00", Offset = "0x4F0D800", VA = "0x184F0EC00")]
		public byte[] GetGenericBytes(out int cbLen)
		{
			return null;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0000983C File Offset: 0x00007A3C
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x4F0AA10", Offset = "0x4F09610", VA = "0x184F0AA10", Slot = "4")]
		public bool Equals(SteamNetworkingIdentity x)
		{
			return default(bool);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x4F0F570", Offset = "0x4F0E170", VA = "0x184F0F570")]
		public void ToString(out string buf)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00009854 File Offset: 0x00007A54
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x4F0EE90", Offset = "0x4F0DA90", VA = "0x184F0EE90")]
		public bool ParseString(string pszStr)
		{
			return default(bool);
		}

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingIdentityType m_eType;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x4")]
		private int m_cbSize;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x8")]
		private uint m_reserved0;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0xC")]
		private uint m_reserved1;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x10")]
		private uint m_reserved2;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x14")]
		private uint m_reserved3;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x18")]
		private uint m_reserved4;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_reserved5;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x20")]
		private uint m_reserved6;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x24")]
		private uint m_reserved7;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x28")]
		private uint m_reserved8;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x2C")]
		private uint m_reserved9;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x30")]
		private uint m_reserved10;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x34")]
		private uint m_reserved11;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x38")]
		private uint m_reserved12;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x3C")]
		private uint m_reserved13;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x40")]
		private uint m_reserved14;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x44")]
		private uint m_reserved15;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x48")]
		private uint m_reserved16;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x4C")]
		private uint m_reserved17;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0x50")]
		private uint m_reserved18;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0x54")]
		private uint m_reserved19;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x58")]
		private uint m_reserved20;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x5C")]
		private uint m_reserved21;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x60")]
		private uint m_reserved22;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x64")]
		private uint m_reserved23;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x68")]
		private uint m_reserved24;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_reserved25;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		[FieldOffset(Offset = "0x70")]
		private uint m_reserved26;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x74")]
		private uint m_reserved27;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x78")]
		private uint m_reserved28;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4000B31")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_reserved29;

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4000B32")]
		[FieldOffset(Offset = "0x80")]
		private uint m_reserved30;

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x84")]
		private uint m_reserved31;

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4000B34")]
		public const int k_cchMaxString = 128;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		public const int k_cchMaxGenericString = 32;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		public const int k_cchMaxXboxPairwiseID = 33;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		public const int k_cbMaxGenericBytes = 32;
	}
}
