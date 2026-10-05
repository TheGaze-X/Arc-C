using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0000A634 File Offset: 0x00008834
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x4F1AAC0", Offset = "0x4F196C0", VA = "0x184F1AAC0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0000A64C File Offset: 0x0000884C
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0000A664 File Offset: 0x00008864
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0000A67C File Offset: 0x0000887C
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x4F1ABA0", Offset = "0x4F197A0", VA = "0x184F1ABA0")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0000A694 File Offset: 0x00008894
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0000A6AC File Offset: 0x000088AC
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0000A6C4 File Offset: 0x000088C4
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0000A6DC File Offset: 0x000088DC
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCUpdateHandle;
	}
}
