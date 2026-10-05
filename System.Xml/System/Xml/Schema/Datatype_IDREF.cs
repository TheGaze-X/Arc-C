using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	internal class Datatype_IDREF : Datatype_NCName
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x17000273")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x2111F40", Offset = "0x2110B40", VA = "0x182111F40", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x17000274")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_IDREF()
		{
		}
	}
}
