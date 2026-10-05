using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000420 RID: 1056
	[Token(Token = "0x2000420")]
	public abstract class X509ObjectIdentifiers
	{
		// Token: 0x060022E6 RID: 8934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509ObjectIdentifiers()
		{
		}

		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		internal const string ID = "2.5.4";

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier CommonName;

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier CountryName;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier LocalityName;

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier StateOrProvinceName;

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier Organization;

		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x28")]
		public static readonly DerObjectIdentifier OrganizationalUnitName;

		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x30")]
		public static readonly DerObjectIdentifier id_at_telephoneNumber;

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DerObjectIdentifier id_at_name;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x40")]
		public static readonly DerObjectIdentifier IdSha1;

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x48")]
		public static readonly DerObjectIdentifier RipeMD160;

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x50")]
		public static readonly DerObjectIdentifier RipeMD160WithRsaEncryption;

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x58")]
		public static readonly DerObjectIdentifier IdEARsa;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x60")]
		public static readonly DerObjectIdentifier IdPkix;

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x68")]
		public static readonly DerObjectIdentifier IdPE;

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0x70")]
		public static readonly DerObjectIdentifier IdAD;

		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x78")]
		public static readonly DerObjectIdentifier IdADCAIssuers;

		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		[FieldOffset(Offset = "0x80")]
		public static readonly DerObjectIdentifier IdADOcsp;

		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		[FieldOffset(Offset = "0x88")]
		public static readonly DerObjectIdentifier OcspAccessMethod;

		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		[FieldOffset(Offset = "0x90")]
		public static readonly DerObjectIdentifier CrlAccessMethod;
	}
}
