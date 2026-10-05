using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	internal class Datatype_hexBinary : Datatype_anySimpleType
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x4FFFB40", Offset = "0x4FFE740", VA = "0x184FFFB40", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x17000252")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x4FFFBE0", Offset = "0x4FFE7E0", VA = "0x184FFFBE0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public override Type ValueType
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x4FFFBF0", Offset = "0x4FFE7F0", VA = "0x184FFFBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x4FFFB90", Offset = "0x4FFE790", VA = "0x184FFFB90", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x17000255")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x4FFF780", Offset = "0x4FFE380", VA = "0x184FFF780", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x4FFF850", Offset = "0x4FFE450", VA = "0x184FFF850", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x4FFFAC0", Offset = "0x4FFE6C0", VA = "0x184FFFAC0")]
		public Datatype_hexBinary()
		{
		}

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
