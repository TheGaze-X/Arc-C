using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	[Serializable]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public SteamItemDef_t(int value)
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x4EDEC00", Offset = "0x4EDD800", VA = "0x184EDEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000091AC File Offset: 0x000073AC
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x4F0E520", Offset = "0x4F0D120", VA = "0x184F0E520", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000091C4 File Offset: 0x000073C4
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000091DC File Offset: 0x000073DC
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000091F4 File Offset: 0x000073F4
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000920C File Offset: 0x0000740C
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00009224 File Offset: 0x00007424
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return 0;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000923C File Offset: 0x0000743C
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00009254 File Offset: 0x00007454
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x4EDEB50", Offset = "0x4EDD750", VA = "0x184EDEB50", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return 0;
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef;
	}
}
