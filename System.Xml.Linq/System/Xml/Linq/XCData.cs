using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class XCData : XText
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F86C90", Offset = "0x4F85890", VA = "0x184F86C90")]
		public XCData(string value)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4F86D20", Offset = "0x4F85920", VA = "0x184F86D20")]
		public XCData(XCData other)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000005")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4F86BF0", Offset = "0x4F857F0", VA = "0x184F86BF0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4F86B20", Offset = "0x4F85720", VA = "0x184F86B20", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}
	}
}
