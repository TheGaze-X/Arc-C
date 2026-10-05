using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200100A RID: 4106
	[Token(Token = "0x200100A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EmojiSceneType
	{
		// Token: 0x04005714 RID: 22292
		[Token(Token = "0x4005714")]
		NONE,
		// Token: 0x04005715 RID: 22293
		[Token(Token = "0x4005715")]
		ACTMULTIV3_ROOM,
		// Token: 0x04005716 RID: 22294
		[Token(Token = "0x4005716")]
		ACTMULTIV3_PICK,
		// Token: 0x04005717 RID: 22295
		[Token(Token = "0x4005717")]
		ACTMULTIV3_BATTLE,
		// Token: 0x04005718 RID: 22296
		[Token(Token = "0x4005718")]
		ENEMYDUEL_BATTLE,
		// Token: 0x04005719 RID: 22297
		[Token(Token = "0x4005719")]
		AUTOCHESS_ROOM,
		// Token: 0x0400571A RID: 22298
		[Token(Token = "0x400571A")]
		AUTOCHESS_BATTLE
	}
}
