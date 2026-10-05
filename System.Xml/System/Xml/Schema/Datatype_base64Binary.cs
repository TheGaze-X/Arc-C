using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	internal class Datatype_base64Binary : Datatype_anySimpleType
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x4FFBC80", Offset = "0x4FFA880", VA = "0x184FFBC80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x17000257")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x4FFBD20", Offset = "0x4FFA920", VA = "0x184FFBD20", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000258")]
		public override Type ValueType
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x4FFBD30", Offset = "0x4FFA930", VA = "0x184FFBD30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000259")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x4FFBCD0", Offset = "0x4FFA8D0", VA = "0x184FFBCD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x1700025A")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x4FFB8D0", Offset = "0x4FFA4D0", VA = "0x184FFB8D0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x4FFB9A0", Offset = "0x4FFA5A0", VA = "0x184FFB9A0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x4FFBC00", Offset = "0x4FFA800", VA = "0x184FFBC00")]
		public Datatype_base64Binary()
		{
		}

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
