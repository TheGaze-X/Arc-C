using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	internal class UnionFacetsChecker : FacetsChecker
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x500A160", Offset = "0x5008D60", VA = "0x18500A160", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x5005330", Offset = "0x5003F30", VA = "0x185005330", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnionFacetsChecker()
		{
		}
	}
}
