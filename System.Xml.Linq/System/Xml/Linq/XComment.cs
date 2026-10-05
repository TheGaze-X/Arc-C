using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class XComment : XNode
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4F86FB0", Offset = "0x4F85BB0", VA = "0x184F86FB0")]
		public XComment(string value)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4F86F20", Offset = "0x4F85B20", VA = "0x184F86F20")]
		public XComment(XComment other)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x17000006")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000007")]
		public string Value
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4F87040", Offset = "0x4F85C40", VA = "0x184F87040")]
			set
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4F86E80", Offset = "0x4F85A80", VA = "0x184F86E80", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4F86DB0", Offset = "0x4F859B0", VA = "0x184F86DB0", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		internal string value;
	}
}
