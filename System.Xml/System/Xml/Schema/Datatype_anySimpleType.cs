using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	internal class Datatype_anySimpleType : DatatypeImplementation
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x4FFAFA0", Offset = "0x4FF9BA0", VA = "0x184FFAFA0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021C")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x4FFB150", Offset = "0x4FF9D50", VA = "0x184FFB150", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021D")]
		public override Type ValueType
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x4FFB1F0", Offset = "0x4FF9DF0", VA = "0x184FFB1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x1700021E")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021F")]
		internal override Type ListValueType
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4FFB1A0", Offset = "0x4FF9DA0", VA = "0x184FFB1A0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x17000220")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x17000221")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x4FFAF10", Offset = "0x4FF9B10", VA = "0x184FFAF10", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x4FFAFF0", Offset = "0x4FF9BF0", VA = "0x184FFAFF0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x4FFB100", Offset = "0x4FF9D00", VA = "0x184FFB100")]
		public Datatype_anySimpleType()
		{
		}

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
