using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[Serializable]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		// Token: 0x06000A19 RID: 2585 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public HAuthTicket(uint value)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x4ED7320", Offset = "0x4ED5F20", VA = "0x184ED7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000896C File Offset: 0x00006B6C
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x4EDE760", Offset = "0x4EDD360", VA = "0x184EDE760", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00008984 File Offset: 0x00006B84
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000899C File Offset: 0x00006B9C
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000089B4 File Offset: 0x00006BB4
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x4EDE840", Offset = "0x4EDD440", VA = "0x184EDE840")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000089CC File Offset: 0x00006BCC
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000089E4 File Offset: 0x00006BE4
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator uint(HAuthTicket that)
		{
			return 0U;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000089FC File Offset: 0x00006BFC
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00008A14 File Offset: 0x00006C14
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x4ED7270", Offset = "0x4ED5E70", VA = "0x184ED7270", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return 0;
		}

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;
	}
}
