using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Network
{
	// Token: 0x0200022E RID: 558
	[Token(Token = "0x200022E")]
	public struct MockMeta
	{
		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty(PropertyName = "case")]
		public string serviceCase;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x8")]
		public object meta;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MockMeta DEFAULT;
	}
}
