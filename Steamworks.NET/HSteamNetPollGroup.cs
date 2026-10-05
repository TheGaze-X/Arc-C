using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	[Serializable]
	public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HSteamNetPollGroup(uint value)
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00009644 File Offset: 0x00007844
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x4EDEF00", Offset = "0x4EDDB00", VA = "0x184EDEF00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000965C File Offset: 0x0000785C
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00009674 File Offset: 0x00007874
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return default(bool);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0000968C File Offset: 0x0000788C
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x4EDEFE0", Offset = "0x4EDDBE0", VA = "0x184EDEFE0")]
		public static bool operator !=(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return default(bool);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000096A4 File Offset: 0x000078A4
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HSteamNetPollGroup(uint value)
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000096BC File Offset: 0x000078BC
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HSteamNetPollGroup that)
		{
			return 0U;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000096D4 File Offset: 0x000078D4
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HSteamNetPollGroup other)
		{
			return default(bool);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000096EC File Offset: 0x000078EC
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HSteamNetPollGroup other)
		{
			return 0;
		}

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HSteamNetPollGroup Invalid;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HSteamNetPollGroup;
	}
}
