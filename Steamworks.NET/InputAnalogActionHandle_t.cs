using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	[Serializable]
	public struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public InputAnalogActionHandle_t(ulong value)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x4EE0CF0", Offset = "0x4EDF8F0", VA = "0x184EE0CF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00008E04 File Offset: 0x00007004
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00008E1C File Offset: 0x0000701C
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00008E34 File Offset: 0x00007034
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00008E4C File Offset: 0x0000704C
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator InputAnalogActionHandle_t(ulong value)
		{
			return default(InputAnalogActionHandle_t);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(InputAnalogActionHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00008E7C File Offset: 0x0000707C
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(InputAnalogActionHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(InputAnalogActionHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputAnalogActionHandle;
	}
}
