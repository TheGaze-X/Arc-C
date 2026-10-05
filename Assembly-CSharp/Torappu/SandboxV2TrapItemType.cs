using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127C RID: 4732
	[Token(Token = "0x200127C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2TrapItemType
	{
		// Token: 0x0400685B RID: 26715
		[Token(Token = "0x400685B")]
		NONE,
		// Token: 0x0400685C RID: 26716
		[Token(Token = "0x400685C")]
		BATTLE,
		// Token: 0x0400685D RID: 26717
		[Token(Token = "0x400685D")]
		TACTICAL,
		// Token: 0x0400685E RID: 26718
		[Token(Token = "0x400685E")]
		FUNCTION,
		// Token: 0x0400685F RID: 26719
		[Token(Token = "0x400685F")]
		ANIMAL
	}
}
