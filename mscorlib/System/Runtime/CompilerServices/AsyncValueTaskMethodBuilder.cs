using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder
	{
		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder _methodBuilder;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _haveResult;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _useBuilder;
	}
}
