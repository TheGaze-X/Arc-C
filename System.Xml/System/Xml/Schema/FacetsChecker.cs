using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	internal abstract class FacetsChecker
	{
		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x5004B70", Offset = "0x5003770", VA = "0x185004B70", Slot = "4")]
		internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
		internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
		internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
		internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
		internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
		internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
		internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "16")]
		internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x5004E30", Offset = "0x5003A30", VA = "0x185004E30")]
		internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x5004BF0", Offset = "0x50037F0", VA = "0x185004BF0")]
		internal Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			return null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "17")]
		internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x5004F70", Offset = "0x5003B70", VA = "0x185004F70")]
		internal static decimal Power(int x, int y)
		{
			return 0m;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected FacetsChecker()
		{
		}
	}
}
