using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	internal class Datatype_dateTimeBase : Datatype_anySimpleType
	{
		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x4FFCDC0", Offset = "0x4FFB9C0", VA = "0x184FFCDC0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000245")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x4FFD320", Offset = "0x4FFBF20", VA = "0x184FFD320", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x17000246")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x4BF3FC0", Offset = "0x4BF2BC0", VA = "0x184BF3FC0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x4FFD290", Offset = "0x4FFBE90", VA = "0x184FFD290")]
		internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000247")]
		public override Type ValueType
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x4FFD3C0", Offset = "0x4FFBFC0", VA = "0x184FFD3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000248")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x4FFD370", Offset = "0x4FFBF70", VA = "0x184FFD370", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x17000249")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x4FFCC60", Offset = "0x4FFB860", VA = "0x184FFCC60", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x4FFCE50", Offset = "0x4FFBA50", VA = "0x184FFCE50", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x38")]
		private XsdDateTimeFlags dateTimeFlags;
	}
}
