using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	public abstract class Asn1TaggedObject : Asn1Object, Asn1TaggedObjectParser, IAsn1Convertible
	{
		// Token: 0x06001F85 RID: 8069 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x5315850", Offset = "0x5314450", VA = "0x185315850")]
		internal static bool IsConstructed(bool isExplicit, Asn1Object obj)
		{
			return default(bool);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x5315320", Offset = "0x5313F20", VA = "0x185315320")]
		public static Asn1TaggedObject GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x5315460", Offset = "0x5314060", VA = "0x185315460")]
		public static Asn1TaggedObject GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x5315AA0", Offset = "0x53146A0", VA = "0x185315AA0")]
		protected Asn1TaggedObject(int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x5315AF0", Offset = "0x53146F0", VA = "0x185315AF0")]
		protected Asn1TaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x5315170", Offset = "0x5313D70", VA = "0x185315170", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x53152C0", Offset = "0x5313EC0", VA = "0x1853152C0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x17000422")]
		public int TagNo
		{
			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
		public bool IsExplicit()
		{
			return default(bool);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x5315800", Offset = "0x5314400", VA = "0x185315800")]
		public Asn1Object GetObject()
		{
			return null;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x53155F0", Offset = "0x53141F0", VA = "0x1853155F0", Slot = "10")]
		public IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x53159E0", Offset = "0x53145E0", VA = "0x1853159E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x10")]
		internal int tagNo;

		// Token: 0x040010F0 RID: 4336
		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x14")]
		internal bool explicitly;

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x18")]
		internal Asn1Encodable obj;
	}
}
