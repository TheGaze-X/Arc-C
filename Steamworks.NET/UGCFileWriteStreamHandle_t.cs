using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[Serializable]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00009E84 File Offset: 0x00008084
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x4F18F40", Offset = "0x4F17B40", VA = "0x184F18F40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00009E9C File Offset: 0x0000809C
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00009EB4 File Offset: 0x000080B4
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00009ECC File Offset: 0x000080CC
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x4F19020", Offset = "0x4F17C20", VA = "0x184F19020")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00009EE4 File Offset: 0x000080E4
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00009EFC File Offset: 0x000080FC
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00009F14 File Offset: 0x00008114
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00009F2C File Offset: 0x0000812C
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;
	}
}
