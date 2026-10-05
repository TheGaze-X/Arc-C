using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	internal class DateTimeFacetsChecker : FacetsChecker
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x5003D40", Offset = "0x5002940", VA = "0x185003D40", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x5003870", Offset = "0x5002470", VA = "0x185003870", Slot = "10")]
		internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x5003E10", Offset = "0x5002A10", VA = "0x185003E10", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x5003EE0", Offset = "0x5002AE0", VA = "0x185003EE0")]
		private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DateTimeFacetsChecker()
		{
		}
	}
}
