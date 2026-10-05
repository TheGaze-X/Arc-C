using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Serializable]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x4F0CB40", Offset = "0x4F0B740", VA = "0x184F0CB40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00009DDC File Offset: 0x00007FDC
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00009DF4 File Offset: 0x00007FF4
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00009E0C File Offset: 0x0000800C
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x4F0CC20", Offset = "0x4F0B820", VA = "0x184F0CC20")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00009E24 File Offset: 0x00008024
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00009E3C File Offset: 0x0000803C
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00009E54 File Offset: 0x00008054
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00009E6C File Offset: 0x0000806C
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;
	}
}
