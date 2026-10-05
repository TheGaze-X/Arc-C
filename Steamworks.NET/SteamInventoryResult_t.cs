using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	[Serializable]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public SteamInventoryResult_t(int value)
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x4EDEC00", Offset = "0x4EDD800", VA = "0x184EDEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0000902C File Offset: 0x0000722C
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x4F0E2B0", Offset = "0x4F0CEB0", VA = "0x184F0E2B0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00009044 File Offset: 0x00007244
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0000905C File Offset: 0x0000725C
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00009074 File Offset: 0x00007274
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x4F0E390", Offset = "0x4F0CF90", VA = "0x184F0E390")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0000908C File Offset: 0x0000728C
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000090A4 File Offset: 0x000072A4
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return 0;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000090BC File Offset: 0x000072BC
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000090D4 File Offset: 0x000072D4
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x4EDEB50", Offset = "0x4EDD750", VA = "0x184EDEB50", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return 0;
		}

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult;
	}
}
