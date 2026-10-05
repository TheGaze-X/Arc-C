using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[Serializable]
	public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public InputDigitalActionHandle_t(ulong value)
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00008EAC File Offset: 0x000070AC
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4EE0D80", Offset = "0x4EDF980", VA = "0x184EE0D80", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00008EC4 File Offset: 0x000070C4
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00008EDC File Offset: 0x000070DC
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00008EF4 File Offset: 0x000070F4
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00008F0C File Offset: 0x0000710C
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator InputDigitalActionHandle_t(ulong value)
		{
			return default(InputDigitalActionHandle_t);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00008F24 File Offset: 0x00007124
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(InputDigitalActionHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00008F3C File Offset: 0x0000713C
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(InputDigitalActionHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00008F54 File Offset: 0x00007154
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(InputDigitalActionHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputDigitalActionHandle;
	}
}
