using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	[Serializable]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0000A574 File Offset: 0x00008774
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x4F1A980", Offset = "0x4F19580", VA = "0x184F1A980", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0000A58C File Offset: 0x0000878C
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0000A5A4 File Offset: 0x000087A4
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000A5BC File Offset: 0x000087BC
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x4F1AA60", Offset = "0x4F19660", VA = "0x184F1AA60")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0000A5EC File Offset: 0x000087EC
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000A604 File Offset: 0x00008804
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0000A61C File Offset: 0x0000881C
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;
	}
}
