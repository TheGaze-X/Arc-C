using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	internal class Datatype_ENTITY : Datatype_NCName
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x17000275")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x4FF9F60", Offset = "0x4FF8B60", VA = "0x184FF9F60", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x17000276")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_ENTITY()
		{
		}
	}
}
