using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	internal class Datatype_anyAtomicType : Datatype_anySimpleType
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x4FFAE40", Offset = "0x4FF9A40", VA = "0x184FFAE40", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x17000222")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x17000223")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x4FFAE90", Offset = "0x4FF9A90", VA = "0x184FFAE90")]
		public Datatype_anyAtomicType()
		{
		}
	}
}
