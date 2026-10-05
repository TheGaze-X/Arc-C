using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	internal class Numeric2FacetsChecker : FacetsChecker
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x5007370", Offset = "0x5005F70", VA = "0x185007370", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5006F80", Offset = "0x5005B80", VA = "0x185006F80", Slot = "11")]
		internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5007310", Offset = "0x5005F10", VA = "0x185007310", Slot = "12")]
		internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x5007550", Offset = "0x5006150", VA = "0x185007550", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x5007450", Offset = "0x5006050", VA = "0x185007450")]
		private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			return default(bool);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Numeric2FacetsChecker()
		{
		}
	}
}
