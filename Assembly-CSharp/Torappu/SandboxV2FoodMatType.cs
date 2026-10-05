using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127B RID: 4731
	[Token(Token = "0x200127B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2FoodMatType
	{
		// Token: 0x04006858 RID: 26712
		[Token(Token = "0x4006858")]
		MAIN,
		// Token: 0x04006859 RID: 26713
		[Token(Token = "0x4006859")]
		SUB
	}
}
