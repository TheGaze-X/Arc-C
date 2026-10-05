using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003646 RID: 13894
	[Token(Token = "0x2003646")]
	public struct StateCache
	{
		// Token: 0x0401A96C RID: 108908
		[Token(Token = "0x401A96C")]
		[FieldOffset(Offset = "0x0")]
		public Type stateType;

		// Token: 0x0401A96D RID: 108909
		[Token(Token = "0x401A96D")]
		[FieldOffset(Offset = "0x8")]
		public StateSource source;

		// Token: 0x0401A96E RID: 108910
		[Token(Token = "0x401A96E")]
		[FieldOffset(Offset = "0x10")]
		public object cache;
	}
}
