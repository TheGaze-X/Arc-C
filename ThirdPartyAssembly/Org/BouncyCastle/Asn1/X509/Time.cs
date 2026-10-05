using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public class Time : Asn1Encodable, IAsn1Choice
	{
		// Token: 0x06002289 RID: 8841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x5344D80", Offset = "0x5343980", VA = "0x185344D80")]
		public static Time GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x5345500", Offset = "0x5344100", VA = "0x185345500")]
		public Time(Asn1Object time)
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x5345370", Offset = "0x5343F70", VA = "0x185345370")]
		public Time(DateTime date)
		{
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x5344B00", Offset = "0x5343700", VA = "0x185344B00")]
		public static Time GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x5344DB0", Offset = "0x53439B0", VA = "0x185344DB0")]
		public string GetTime()
		{
			return null;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x5345020", Offset = "0x5343C20", VA = "0x185345020")]
		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x5345360", Offset = "0x5343F60", VA = "0x185345360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1Object time;
	}
}
