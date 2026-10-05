using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	[Serializable]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public PublishedFileId_t(ulong value)
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00009D04 File Offset: 0x00007F04
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4F0CA00", Offset = "0x4F0B600", VA = "0x184F0CA00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00009D1C File Offset: 0x00007F1C
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00009D34 File Offset: 0x00007F34
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x4F0CAE0", Offset = "0x4F0B6E0", VA = "0x184F0CAE0")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00009D64 File Offset: 0x00007F64
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00009D94 File Offset: 0x00007F94
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00009DAC File Offset: 0x00007FAC
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return 0;
		}

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;
	}
}
