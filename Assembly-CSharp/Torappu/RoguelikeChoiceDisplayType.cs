using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001213 RID: 4627
	[Token(Token = "0x2001213")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeChoiceDisplayType
	{
		// Token: 0x040063E5 RID: 25573
		[Token(Token = "0x40063E5")]
		NONE,
		// Token: 0x040063E6 RID: 25574
		[Token(Token = "0x40063E6")]
		NORMAL,
		// Token: 0x040063E7 RID: 25575
		[Token(Token = "0x40063E7")]
		ITEM,
		// Token: 0x040063E8 RID: 25576
		[Token(Token = "0x40063E8")]
		TASK
	}
}
