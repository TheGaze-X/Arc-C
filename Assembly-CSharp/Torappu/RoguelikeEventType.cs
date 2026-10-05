using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011C7 RID: 4551
	[Token(Token = "0x20011C7")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeEventType
	{
		// Token: 0x04006168 RID: 24936
		[Token(Token = "0x4006168")]
		NONE,
		// Token: 0x04006169 RID: 24937
		[Token(Token = "0x4006169")]
		BATTLE_NORMAL,
		// Token: 0x0400616A RID: 24938
		[Token(Token = "0x400616A")]
		BATTLE_ELITE,
		// Token: 0x0400616B RID: 24939
		[Token(Token = "0x400616B")]
		BATTLE_BOSS = 4,
		// Token: 0x0400616C RID: 24940
		[Token(Token = "0x400616C")]
		SHOP = 8,
		// Token: 0x0400616D RID: 24941
		[Token(Token = "0x400616D")]
		REST = 16,
		// Token: 0x0400616E RID: 24942
		[Token(Token = "0x400616E")]
		INCIDENT = 32,
		// Token: 0x0400616F RID: 24943
		[Token(Token = "0x400616F")]
		TREASURE = 64,
		// Token: 0x04006170 RID: 24944
		[Token(Token = "0x4006170")]
		ENTERTAINMENT = 128,
		// Token: 0x04006171 RID: 24945
		[Token(Token = "0x4006171")]
		UNKNOWN = 256,
		// Token: 0x04006172 RID: 24946
		[Token(Token = "0x4006172")]
		WISH = 512,
		// Token: 0x04006173 RID: 24947
		[Token(Token = "0x4006173")]
		SACRIFICE = 1024,
		// Token: 0x04006174 RID: 24948
		[Token(Token = "0x4006174")]
		EXPEDITION = 2048,
		// Token: 0x04006175 RID: 24949
		[Token(Token = "0x4006175")]
		BATTLE_SHOP = 4096,
		// Token: 0x04006176 RID: 24950
		[Token(Token = "0x4006176")]
		PORTAL = 8192,
		// Token: 0x04006177 RID: 24951
		[Token(Token = "0x4006177")]
		MISSION = 16384,
		// Token: 0x04006178 RID: 24952
		[Token(Token = "0x4006178")]
		STORY = 32768,
		// Token: 0x04006179 RID: 24953
		[Token(Token = "0x4006179")]
		STORY_HIDDEN = 65536,
		// Token: 0x0400617A RID: 24954
		[Token(Token = "0x400617A")]
		ALCHEMY = 131072,
		// Token: 0x0400617B RID: 24955
		[Token(Token = "0x400617B")]
		DUEL = 262144,
		// Token: 0x0400617C RID: 24956
		[Token(Token = "0x400617C")]
		STASHED_RECRUIT = 524288,
		// Token: 0x0400617D RID: 24957
		[Token(Token = "0x400617D")]
		SPECIAL_ZONE = 1048576,
		// Token: 0x0400617E RID: 24958
		[Token(Token = "0x400617E")]
		BATTLES = 7,
		// Token: 0x0400617F RID: 24959
		[Token(Token = "0x400617F")]
		CHOICES = 1961712,
		// Token: 0x04006180 RID: 24960
		[Token(Token = "0x4006180")]
		EVENTS = 1965816,
		// Token: 0x04006181 RID: 24961
		[Token(Token = "0x4006181")]
		ALL = 1965823
	}
}
