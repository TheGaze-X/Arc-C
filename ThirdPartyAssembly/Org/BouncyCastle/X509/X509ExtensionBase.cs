using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public abstract class X509ExtensionBase : IX509Extension
	{
		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x600063B")]
		protected abstract X509Extensions GetX509Extensions();

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x54572A0", Offset = "0x5455EA0", VA = "0x1854572A0", Slot = "9")]
		protected virtual ISet GetExtensionOids(bool critical)
		{
			return null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x518A3C0", Offset = "0x5188FC0", VA = "0x18518A3C0", Slot = "10")]
		public virtual ISet GetNonCriticalExtensionOids()
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x5457260", Offset = "0x5455E60", VA = "0x185457260", Slot = "11")]
		public virtual ISet GetCriticalExtensionOids()
		{
			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x54575F0", Offset = "0x54561F0", VA = "0x1854575F0", Slot = "6")]
		[Obsolete("Use version taking a DerObjectIdentifier instead")]
		public Asn1OctetString GetExtensionValue(string oid)
		{
			return null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5457690", Offset = "0x5456290", VA = "0x185457690", Slot = "12")]
		public virtual Asn1OctetString GetExtensionValue(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509ExtensionBase()
		{
		}
	}
}
