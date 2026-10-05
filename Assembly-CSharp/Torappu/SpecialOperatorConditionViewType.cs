using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001333 RID: 4915
	[Token(Token = "0x2001333")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpecialOperatorConditionViewType
	{
		// Token: 0x04006D0D RID: 27917
		[Token(Token = "0x4006D0D")]
		TASK,
		// Token: 0x04006D0E RID: 27918
		[Token(Token = "0x4006D0E")]
		EVOLVEPHASE
	}
}
