using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[Serializable]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public UGCHandle_t(ulong value)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00009F44 File Offset: 0x00008144
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x4F19080", Offset = "0x4F17C80", VA = "0x184F19080", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00009F5C File Offset: 0x0000815C
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00009F74 File Offset: 0x00008174
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00009F8C File Offset: 0x0000818C
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x4F19160", Offset = "0x4F17D60", VA = "0x184F19160")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00009FA4 File Offset: 0x000081A4
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00009FBC File Offset: 0x000081BC
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00009FD4 File Offset: 0x000081D4
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00009FEC File Offset: 0x000081EC
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;
	}
}
