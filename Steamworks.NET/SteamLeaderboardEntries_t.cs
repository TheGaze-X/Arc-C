using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	[Serializable]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x4F1A860", Offset = "0x4F19460", VA = "0x184F1A860", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0000A70C File Offset: 0x0000890C
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0000A724 File Offset: 0x00008924
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000A73C File Offset: 0x0000893C
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0000A754 File Offset: 0x00008954
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0000A76C File Offset: 0x0000896C
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0000A784 File Offset: 0x00008984
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0000A79C File Offset: 0x0000899C
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return 0;
		}

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;
	}
}
