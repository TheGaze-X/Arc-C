using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class ECNamedCurveTable
	{
		// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x533C320", Offset = "0x533AF20", VA = "0x18533C320")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x533C570", Offset = "0x533B170", VA = "0x18533C570")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x533C710", Offset = "0x533B310", VA = "0x18533C710")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x533C490", Offset = "0x533B090", VA = "0x18533C490")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000446")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002149")]
			[Address(RVA = "0x533C820", Offset = "0x533B420", VA = "0x18533C820")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ECNamedCurveTable()
		{
		}
	}
}
