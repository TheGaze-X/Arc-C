using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	[Serializable]
	public struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public InputActionSetHandle_t(ulong value)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00008D2C File Offset: 0x00006F2C
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4EE0C60", Offset = "0x4EDF860", VA = "0x184EE0C60", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00008D74 File Offset: 0x00006F74
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00008D8C File Offset: 0x00006F8C
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator InputActionSetHandle_t(ulong value)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(InputActionSetHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(InputActionSetHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(InputActionSetHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_InputActionSetHandle;
	}
}
