using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	internal class QNameFacetsChecker : FacetsChecker
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x5007920", Offset = "0x5006520", VA = "0x185007920", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x50076E0", Offset = "0x50062E0", VA = "0x1850076E0", Slot = "16")]
		internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x5007C40", Offset = "0x5006840", VA = "0x185007C40", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x5007AC0", Offset = "0x50066C0", VA = "0x185007AC0")]
		private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration)
		{
			return default(bool);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QNameFacetsChecker()
		{
		}
	}
}
