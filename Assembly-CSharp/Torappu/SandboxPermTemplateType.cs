using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012FA RID: 4858
	[Token(Token = "0x20012FA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxPermTemplateType
	{
		// Token: 0x04006B9D RID: 27549
		[Token(Token = "0x4006B9D")]
		NONE,
		// Token: 0x04006B9E RID: 27550
		[Token(Token = "0x4006B9E")]
		SANDBOX_V2
	}
}
