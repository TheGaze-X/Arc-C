using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000EBF RID: 3775
	[Token(Token = "0x2000EBF")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act6FunAchievementType
	{
		// Token: 0x04004FD3 RID: 20435
		[Token(Token = "0x4004FD3")]
		NORMAL,
		// Token: 0x04004FD4 RID: 20436
		[Token(Token = "0x4004FD4")]
		EX
	}
}
