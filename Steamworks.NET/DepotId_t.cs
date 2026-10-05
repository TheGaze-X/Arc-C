using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	[Serializable]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public DepotId_t(uint value)
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000A244 File Offset: 0x00008444
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4EDD720", Offset = "0x4EDC320", VA = "0x184EDD720", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000A25C File Offset: 0x0000845C
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0000A274 File Offset: 0x00008474
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000A28C File Offset: 0x0000848C
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4EDD800", Offset = "0x4EDC400", VA = "0x184EDD800")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000A2A4 File Offset: 0x000084A4
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0000A2BC File Offset: 0x000084BC
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(DepotId_t that)
		{
			return 0U;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000A2D4 File Offset: 0x000084D4
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0000A2EC File Offset: 0x000084EC
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return 0;
		}

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x0")]
		public uint m_DepotId;
	}
}
