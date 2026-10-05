using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdleBattleItemType
	{
		// Token: 0x0400420E RID: 16910
		[Token(Token = "0x400420E")]
		EQUIP,
		// Token: 0x0400420F RID: 16911
		[Token(Token = "0x400420F")]
		TRAP
	}
}
