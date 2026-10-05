using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	[Serializable]
	public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public SteamInventoryUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000090EC File Offset: 0x000072EC
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x4F0E3E0", Offset = "0x4F0CFE0", VA = "0x184F0E3E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00009104 File Offset: 0x00007304
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000911C File Offset: 0x0000731C
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00009134 File Offset: 0x00007334
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x4F0E4C0", Offset = "0x4F0D0C0", VA = "0x184F0E4C0")]
		public static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0000914C File Offset: 0x0000734C
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00009164 File Offset: 0x00007364
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(SteamInventoryUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000917C File Offset: 0x0000737C
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(SteamInventoryUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00009194 File Offset: 0x00007394
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryUpdateHandle_t Invalid;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamInventoryUpdateHandle;
	}
}
