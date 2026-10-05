using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public sealed class Oid
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Oid()
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x5124870", Offset = "0x5123470", VA = "0x185124870")]
		public Oid(string oid)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public Oid(string value, string friendlyName)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x51247D0", Offset = "0x51233D0", VA = "0x1851247D0")]
		public Oid(Oid oid)
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x5124650", Offset = "0x5123250", VA = "0x185124650")]
		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			return null;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013D")]
		public string Value
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		public string FriendlyName
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x5124900", Offset = "0x5123500", VA = "0x185124900")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4BD7FE0", Offset = "0x4BD6BE0", VA = "0x184BD7FE0")]
		private Oid(string value, string friendlyName, OidGroup group)
		{
		}

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x10")]
		private string _value;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x18")]
		private string _friendlyName;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x20")]
		private OidGroup _group;
	}
}
