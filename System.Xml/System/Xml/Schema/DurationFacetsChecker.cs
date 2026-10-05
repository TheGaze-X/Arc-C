using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	internal class DurationFacetsChecker : FacetsChecker
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x50047F0", Offset = "0x50033F0", VA = "0x1850047F0", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x5004400", Offset = "0x5003000", VA = "0x185004400", Slot = "15")]
		internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x5004960", Offset = "0x5003560", VA = "0x185004960", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x50049F0", Offset = "0x50035F0", VA = "0x1850049F0")]
		private bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
		{
			return default(bool);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DurationFacetsChecker()
		{
		}
	}
}
