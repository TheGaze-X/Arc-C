using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	internal class Datatype_decimal : Datatype_anySimpleType
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x4FFD8D0", Offset = "0x4FFC4D0", VA = "0x184FFD8D0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000239")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x4FFDD70", Offset = "0x4FFC970", VA = "0x184FFDD70", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x1700023A")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x4CC3770", Offset = "0x4CC2370", VA = "0x184CC3770", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023B")]
		public override Type ValueType
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x4FFDE10", Offset = "0x4FFCA10", VA = "0x184FFDE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023C")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x4FFDDC0", Offset = "0x4FFC9C0", VA = "0x184FFDDC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x1700023D")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x4FFD830", Offset = "0x4FFC430", VA = "0x184FFD830", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x4FFD960", Offset = "0x4FFC560", VA = "0x184FFD960", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x4FFDCF0", Offset = "0x4FFC8F0", VA = "0x184FFDCF0")]
		public Datatype_decimal()
		{
		}

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
