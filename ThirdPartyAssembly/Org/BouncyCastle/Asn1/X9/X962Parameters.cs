using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public class X962Parameters : Asn1Encodable, IAsn1Choice
	{
		// Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x5351CD0", Offset = "0x53508D0", VA = "0x185351CD0")]
		public static X962Parameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x5352000", Offset = "0x5350C00", VA = "0x185352000")]
		public X962Parameters(X9ECParameters ecParameters)
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public X962Parameters(DerObjectIdentifier namedCurve)
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public X962Parameters(Asn1Object obj)
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x17000448")]
		public bool IsNamedCurve
		{
			[Token(Token = "0x600219C")]
			[Address(RVA = "0x5352100", Offset = "0x5350D00", VA = "0x185352100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x17000449")]
		public bool IsImplicitlyCA
		{
			[Token(Token = "0x600219D")]
			[Address(RVA = "0x5352070", Offset = "0x5350C70", VA = "0x185352070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044A")]
		public Asn1Object Parameters
		{
			[Token(Token = "0x600219E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400117C RID: 4476
		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1Object _params;
	}
}
