using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X9;

namespace Org.BouncyCastle.Asn1.Nist
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	public sealed class NistNamedCurves
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private NistNamedCurves()
		{
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x536A200", Offset = "0x5368E00", VA = "0x18536A200")]
		private static void DefineCurveAlias(string name, DerObjectIdentifier oid)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x536A300", Offset = "0x5368F00", VA = "0x18536A300")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x536A4D0", Offset = "0x53690D0", VA = "0x18536A4D0")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x536A5D0", Offset = "0x53691D0", VA = "0x18536A5D0")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x536A520", Offset = "0x5369120", VA = "0x18536A520")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public static IEnumerable Names
		{
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0x536AAB0", Offset = "0x53696B0", VA = "0x18536AAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary names;
	}
}
