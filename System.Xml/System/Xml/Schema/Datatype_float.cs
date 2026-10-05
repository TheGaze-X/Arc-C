using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	internal class Datatype_float : Datatype_anySimpleType
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4FFE1E0", Offset = "0x4FFCDE0", VA = "0x184FFE1E0", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022F")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x4FFF690", Offset = "0x4FFE290", VA = "0x184FFF690", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x17000230")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x4D502D0", Offset = "0x4D4EED0", VA = "0x184D502D0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000231")]
		public override Type ValueType
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x4FFF730", Offset = "0x4FFE330", VA = "0x184FFF730", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000232")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x4FFF6E0", Offset = "0x4FFE2E0", VA = "0x184FFF6E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x17000233")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4FFF2F0", Offset = "0x4FFDEF0", VA = "0x184FFF2F0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x4FFF370", Offset = "0x4FFDF70", VA = "0x184FFF370", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x4FFF610", Offset = "0x4FFE210", VA = "0x184FFF610")]
		public Datatype_float()
		{
		}

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
