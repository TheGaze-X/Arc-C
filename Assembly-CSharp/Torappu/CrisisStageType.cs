using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FAA RID: 4010
	[Token(Token = "0x2000FAA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisStageType
	{
		// Token: 0x0400551A RID: 21786
		[Token(Token = "0x400551A")]
		TEMPORARY,
		// Token: 0x0400551B RID: 21787
		[Token(Token = "0x400551B")]
		PERMANENT,
		// Token: 0x0400551C RID: 21788
		[Token(Token = "0x400551C")]
		TRAINING
	}
}
