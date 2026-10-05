using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class XObjectChangeEventArgs : EventArgs
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4F8D210", Offset = "0x4F8BE10", VA = "0x184F8D210")]
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x10")]
		private XObjectChange _objectChange;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XObjectChangeEventArgs Add;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x8")]
		public static readonly XObjectChangeEventArgs Remove;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x10")]
		public static readonly XObjectChangeEventArgs Name;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		public static readonly XObjectChangeEventArgs Value;
	}
}
