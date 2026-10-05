using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x4FD4320", Offset = "0x4FD2F20", VA = "0x184FD4320")]
		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x1700018C")]
		public XmlNodeChangedAction Action
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return XmlNodeChangedAction.Insert;
			}
		}

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x10")]
		private XmlNodeChangedAction action;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		private XmlNode node;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x20")]
		private XmlNode oldParent;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		private XmlNode newParent;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x30")]
		private string oldValue;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x38")]
		private string newValue;
	}
}
