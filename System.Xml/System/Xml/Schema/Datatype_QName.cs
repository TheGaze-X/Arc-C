using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	internal class Datatype_QName : Datatype_anySimpleType
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x4FFAD40", Offset = "0x4FF9940", VA = "0x184FFAD40", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x17000261")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x3709B30", Offset = "0x3708730", VA = "0x183709B30", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x17000262")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000263")]
		public override Type ValueType
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x4FFADF0", Offset = "0x4FF99F0", VA = "0x184FFADF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x4FFADA0", Offset = "0x4FF99A0", VA = "0x184FFADA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x17000265")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x4FFA9E0", Offset = "0x4FF95E0", VA = "0x184FFA9E0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x4FFACC0", Offset = "0x4FF98C0", VA = "0x184FFACC0")]
		public Datatype_QName()
		{
		}

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
