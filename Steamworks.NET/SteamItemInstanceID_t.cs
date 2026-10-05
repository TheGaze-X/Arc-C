using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[Serializable]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0000926C File Offset: 0x0000746C
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x4F0E5A0", Offset = "0x4F0D1A0", VA = "0x184F0E5A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00009284 File Offset: 0x00007484
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0000929C File Offset: 0x0000749C
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000092B4 File Offset: 0x000074B4
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x4F0E680", Offset = "0x4F0D280", VA = "0x184F0E680")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000092CC File Offset: 0x000074CC
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000092E4 File Offset: 0x000074E4
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return 0UL;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000092FC File Offset: 0x000074FC
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00009314 File Offset: 0x00007514
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return 0;
		}

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID;
	}
}
