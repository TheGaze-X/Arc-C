using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	internal class ListFacetsChecker : FacetsChecker
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x50050A0", Offset = "0x5003CA0", VA = "0x1850050A0", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x5005330", Offset = "0x5003F30", VA = "0x185005330", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ListFacetsChecker()
		{
		}
	}
}
