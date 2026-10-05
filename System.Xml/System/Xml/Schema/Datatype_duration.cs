using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	internal class Datatype_duration : Datatype_anySimpleType
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x4FFA120", Offset = "0x4FF8D20", VA = "0x184FFA120", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023E")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x4FFE9F0", Offset = "0x4FFD5F0", VA = "0x184FFE9F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x1700023F")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x4DF2DE0", Offset = "0x4DF19E0", VA = "0x184DF2DE0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		public override Type ValueType
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x4FFEA90", Offset = "0x4FFD690", VA = "0x184FFEA90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000241")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x4FFEA40", Offset = "0x4FFD640", VA = "0x184FFEA40", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x17000242")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x4FFE5D0", Offset = "0x4FFD1D0", VA = "0x184FFE5D0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x4FFE670", Offset = "0x4FFD270", VA = "0x184FFE670", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x4FFE970", Offset = "0x4FFD570", VA = "0x184FFE970")]
		public Datatype_duration()
		{
		}

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
