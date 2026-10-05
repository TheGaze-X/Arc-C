using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal class XObjectChangeAnnotation
	{
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x10")]
		internal EventHandler<XObjectChangeEventArgs> changing;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		internal EventHandler<XObjectChangeEventArgs> changed;
	}
}
