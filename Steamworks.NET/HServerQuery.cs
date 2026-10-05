using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[Serializable]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HServerQuery(int value)
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x4EDEC00", Offset = "0x4EDD800", VA = "0x184EDEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000093D4 File Offset: 0x000075D4
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x4EDEB60", Offset = "0x4EDD760", VA = "0x184EDEB60", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000093EC File Offset: 0x000075EC
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00009404 File Offset: 0x00007604
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000941C File Offset: 0x0000761C
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x4EDEC50", Offset = "0x4EDD850", VA = "0x184EDEC50")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00009434 File Offset: 0x00007634
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000944C File Offset: 0x0000764C
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(HServerQuery that)
		{
			return 0;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00009464 File Offset: 0x00007664
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0000947C File Offset: 0x0000767C
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x4EDEB50", Offset = "0x4EDD750", VA = "0x184EDEB50", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return 0;
		}

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;
	}
}
