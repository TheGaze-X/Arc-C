using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200364D RID: 13901
	[Token(Token = "0x200364D")]
	public struct StateTransContext
	{
		// Token: 0x0401A97A RID: 108922
		[Token(Token = "0x401A97A")]
		[FieldOffset(Offset = "0x0")]
		public State from;

		// Token: 0x0401A97B RID: 108923
		[Token(Token = "0x401A97B")]
		[FieldOffset(Offset = "0x8")]
		public State to;

		// Token: 0x0401A97C RID: 108924
		[Token(Token = "0x401A97C")]
		[FieldOffset(Offset = "0x10")]
		public StateTransOptions options;

		// Token: 0x0401A97D RID: 108925
		[Token(Token = "0x401A97D")]
		[FieldOffset(Offset = "0x18")]
		public Stack<Type> predicatedStack;
	}
}
