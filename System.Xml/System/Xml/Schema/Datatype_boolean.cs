using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	internal class Datatype_boolean : Datatype_anySimpleType
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4FFBE10", Offset = "0x4FFAA10", VA = "0x184FFBE10", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022A")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x4FFC140", Offset = "0x4FFAD40", VA = "0x184FFC140", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x1700022B")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x4CF88A0", Offset = "0x4CF74A0", VA = "0x184CF88A0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022C")]
		public override Type ValueType
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x4FFC1E0", Offset = "0x4FFADE0", VA = "0x184FFC1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022D")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x4FFC190", Offset = "0x4FFAD90", VA = "0x184FFC190", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x1700022E")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4FFBD80", Offset = "0x4FFA980", VA = "0x184FFBD80", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4FFBEA0", Offset = "0x4FFAAA0", VA = "0x184FFBEA0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4FFC0C0", Offset = "0x4FFACC0", VA = "0x184FFC0C0")]
		public Datatype_boolean()
		{
		}

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
