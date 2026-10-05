using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	[Serializable]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0000A7B4 File Offset: 0x000089B4
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x4F1A8F0", Offset = "0x4F194F0", VA = "0x184F1A8F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0000A7CC File Offset: 0x000089CC
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0000A7E4 File Offset: 0x000089E4
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0000A7FC File Offset: 0x000089FC
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0000A814 File Offset: 0x00008A14
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0000A82C File Offset: 0x00008A2C
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0000A844 File Offset: 0x00008A44
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0000A85C File Offset: 0x00008A5C
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return 0;
		}

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;
	}
}
