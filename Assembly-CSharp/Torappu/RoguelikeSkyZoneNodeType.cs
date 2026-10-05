using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011C2 RID: 4546
	[Token(Token = "0x20011C2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeSkyZoneNodeType
	{
		// Token: 0x04006147 RID: 24903
		[Token(Token = "0x4006147")]
		NONE,
		// Token: 0x04006148 RID: 24904
		[Token(Token = "0x4006148")]
		ORIGIN,
		// Token: 0x04006149 RID: 24905
		[Token(Token = "0x4006149")]
		BATTLE,
		// Token: 0x0400614A RID: 24906
		[Token(Token = "0x400614A")]
		TRIAL_GATE = 4,
		// Token: 0x0400614B RID: 24907
		[Token(Token = "0x400614B")]
		INCIDENT = 8,
		// Token: 0x0400614C RID: 24908
		[Token(Token = "0x400614C")]
		TREASURE = 16,
		// Token: 0x0400614D RID: 24909
		[Token(Token = "0x400614D")]
		SHOP = 32,
		// Token: 0x0400614E RID: 24910
		[Token(Token = "0x400614E")]
		SACRIFICE = 64,
		// Token: 0x0400614F RID: 24911
		[Token(Token = "0x400614F")]
		ENTERTAINMENT = 128,
		// Token: 0x04006150 RID: 24912
		[Token(Token = "0x4006150")]
		MARKET = 256,
		// Token: 0x04006151 RID: 24913
		[Token(Token = "0x4006151")]
		BATTLE_HARD = 512,
		// Token: 0x04006152 RID: 24914
		[Token(Token = "0x4006152")]
		INCIDENT_BOSS = 1024,
		// Token: 0x04006153 RID: 24915
		[Token(Token = "0x4006153")]
		INCIDENT_BOSS_ONLY = 2048,
		// Token: 0x04006154 RID: 24916
		[Token(Token = "0x4006154")]
		CHOICES = 3548,
		// Token: 0x04006155 RID: 24917
		[Token(Token = "0x4006155")]
		BATTLES = 514
	}
}
