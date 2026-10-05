using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011F6 RID: 4598
	[Token(Token = "0x20011F6")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTopicDevTokenDisplayForm
	{
		// Token: 0x040062DE RID: 25310
		[Token(Token = "0x40062DE")]
		ABSOLUTE_VAL,
		// Token: 0x040062DF RID: 25311
		[Token(Token = "0x40062DF")]
		PERCENTAGE
	}
}
