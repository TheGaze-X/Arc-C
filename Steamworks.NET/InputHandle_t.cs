using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[Serializable]
	public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public InputHandle_t(ulong value)
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00008F6C File Offset: 0x0000716C
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x4EE0E10", Offset = "0x4EDFA10", VA = "0x184EE0E10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00008F84 File Offset: 0x00007184
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00008F9C File Offset: 0x0000719C
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(InputHandle_t x, InputHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(InputHandle_t x, InputHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00008FCC File Offset: 0x000071CC
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator InputHandle_t(ulong value)
		{
			return default(InputHandle_t);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00008FE4 File Offset: 0x000071E4
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(InputHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00008FFC File Offset: 0x000071FC
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(InputHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00009014 File Offset: 0x00007214
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(InputHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputHandle;
	}
}
