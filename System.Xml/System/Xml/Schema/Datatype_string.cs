using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	internal class Datatype_string : Datatype_anySimpleType
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x50014F0", Offset = "0x50000F0", VA = "0x1850014F0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x17000226")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000227")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x50016D0", Offset = "0x50002D0", VA = "0x1850016D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x17000228")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x17000229")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x5001500", Offset = "0x5000100", VA = "0x185001500", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x5001650", Offset = "0x5000250", VA = "0x185001650")]
		public Datatype_string()
		{
		}
	}
}
