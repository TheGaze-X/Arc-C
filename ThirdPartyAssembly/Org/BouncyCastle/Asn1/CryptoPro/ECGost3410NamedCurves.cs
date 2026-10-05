using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	public sealed class ECGost3410NamedCurves
	{
		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private ECGost3410NamedCurves()
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x53617D0", Offset = "0x53603D0", VA = "0x1853617D0")]
		public static ECDomainParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BD")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002400")]
			[Address(RVA = "0x53629D0", Offset = "0x53615D0", VA = "0x1853629D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x5361600", Offset = "0x5360200", VA = "0x185361600")]
		public static ECDomainParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x53618E0", Offset = "0x53604E0", VA = "0x1853618E0")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x5361990", Offset = "0x5360590", VA = "0x185361990")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly IDictionary objIds;

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly IDictionary parameters;

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly IDictionary names;
	}
}
