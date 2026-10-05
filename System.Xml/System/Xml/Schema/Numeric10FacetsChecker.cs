using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	internal class Numeric10FacetsChecker : FacetsChecker
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x5006F40", Offset = "0x5005B40", VA = "0x185006F40")]
		internal Numeric10FacetsChecker(decimal minVal, decimal maxVal)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x50061B0", Offset = "0x5004DB0", VA = "0x1850061B0", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x50062A0", Offset = "0x5004EA0", VA = "0x1850062A0", Slot = "6")]
		internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x5006B80", Offset = "0x5005780", VA = "0x185006B80", Slot = "7")]
		internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x5006AD0", Offset = "0x50056D0", VA = "0x185006AD0", Slot = "8")]
		internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x5006100", Offset = "0x5004D00", VA = "0x185006100", Slot = "9")]
		internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x5006C30", Offset = "0x5005830", VA = "0x185006C30", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x5006D40", Offset = "0x5005940", VA = "0x185006D40")]
		internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			return default(bool);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x5005D40", Offset = "0x5004940", VA = "0x185005D40")]
		internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
		{
			return null;
		}

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] signs;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x10")]
		private decimal maxValue;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x20")]
		private decimal minValue;
	}
}
