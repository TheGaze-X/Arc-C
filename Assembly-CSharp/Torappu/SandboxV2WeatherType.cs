using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127E RID: 4734
	[Token(Token = "0x200127E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2WeatherType
	{
		// Token: 0x0400686B RID: 26731
		[Token(Token = "0x400686B")]
		NORMAL,
		// Token: 0x0400686C RID: 26732
		[Token(Token = "0x400686C")]
		RAINFOREST,
		// Token: 0x0400686D RID: 26733
		[Token(Token = "0x400686D")]
		VOLCANO,
		// Token: 0x0400686E RID: 26734
		[Token(Token = "0x400686E")]
		DESERT
	}
}
