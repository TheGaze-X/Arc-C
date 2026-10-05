using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F70 RID: 3952
	[Token(Token = "0x2000F70")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpCharMissionCondType
	{
		// Token: 0x040053EB RID: 21483
		[Token(Token = "0x40053EB")]
		NONE,
		// Token: 0x040053EC RID: 21484
		[Token(Token = "0x40053EC")]
		EVOLVE_PHASE
	}
}
