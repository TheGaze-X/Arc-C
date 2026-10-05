using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	internal class Datatype_ID : Datatype_NCName
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x17000271")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x4FF9F70", Offset = "0x4FF8B70", VA = "0x184FF9F70", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x17000272")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_ID()
		{
		}
	}
}
