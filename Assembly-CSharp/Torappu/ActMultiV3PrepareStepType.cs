using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x2000E34")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3PrepareStepType
	{
		// Token: 0x04004BA0 RID: 19360
		[Token(Token = "0x4004BA0")]
		NONE,
		// Token: 0x04004BA1 RID: 19361
		[Token(Token = "0x4004BA1")]
		STAGE_CHOOSE,
		// Token: 0x04004BA2 RID: 19362
		[Token(Token = "0x4004BA2")]
		ENTRANCE,
		// Token: 0x04004BA3 RID: 19363
		[Token(Token = "0x4004BA3")]
		CHAR_PICK,
		// Token: 0x04004BA4 RID: 19364
		[Token(Token = "0x4004BA4")]
		SYS_ALLOC,
		// Token: 0x04004BA5 RID: 19365
		[Token(Token = "0x4004BA5")]
		SQUAD_CHECK
	}
}
