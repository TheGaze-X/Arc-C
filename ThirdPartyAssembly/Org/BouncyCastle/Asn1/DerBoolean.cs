using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	public class DerBoolean : Asn1Object
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x531CD20", Offset = "0x531B920", VA = "0x18531CD20")]
		public static DerBoolean GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x531CEA0", Offset = "0x531BAA0", VA = "0x18531CEA0")]
		public static DerBoolean GetInstance(bool value)
		{
			return null;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x531CAD0", Offset = "0x531B6D0", VA = "0x18531CAD0")]
		public static DerBoolean GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x531D090", Offset = "0x531BC90", VA = "0x18531D090")]
		public DerBoolean(byte[] val)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x531D050", Offset = "0x531BC50", VA = "0x18531D050")]
		private DerBoolean(bool value)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x1700042A")]
		public bool IsTrue
		{
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x531D130", Offset = "0x531BD30", VA = "0x18531D130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x531C890", Offset = "0x531B490", VA = "0x18531C890", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x531C780", Offset = "0x531B380", VA = "0x18531C780", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x531C830", Offset = "0x531B430", VA = "0x18531C830", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x531CF30", Offset = "0x531BB30", VA = "0x18531CF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x531C910", Offset = "0x531B510", VA = "0x18531C910")]
		internal static DerBoolean FromOctetString(byte[] value)
		{
			return null;
		}

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte value;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerBoolean False;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerBoolean True;
	}
}
