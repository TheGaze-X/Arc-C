using System;
using System.Collections;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	internal class StringFacetsChecker : FacetsChecker
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		private static Regex LanguagePattern
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x500A0A0", Offset = "0x5008CA0", VA = "0x18500A0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x50099B0", Offset = "0x50085B0", VA = "0x1850099B0", Slot = "5")]
		internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x5009990", Offset = "0x5008590", VA = "0x185009990", Slot = "13")]
		internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			return null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x5009A70", Offset = "0x5008670", VA = "0x185009A70")]
		internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri)
		{
			return null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x5009FD0", Offset = "0x5008BD0", VA = "0x185009FD0", Slot = "17")]
		internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x5009D10", Offset = "0x5008910", VA = "0x185009D10")]
		private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			return default(bool);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x5009680", Offset = "0x5008280", VA = "0x185009680")]
		private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri)
		{
			return null;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StringFacetsChecker()
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x0")]
		private static Regex languagePattern;
	}
}
