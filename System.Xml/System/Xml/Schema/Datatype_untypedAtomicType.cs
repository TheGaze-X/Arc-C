using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
	{
		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x5003010", Offset = "0x5001C10", VA = "0x185003010", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x17000224")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x17000225")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x2110790", Offset = "0x210F390", VA = "0x182110790", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x4FFAE90", Offset = "0x4FF9A90", VA = "0x184FFAE90")]
		public Datatype_untypedAtomicType()
		{
		}
	}
}
