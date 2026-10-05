using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D97 RID: 3479
	[Token(Token = "0x2000D97")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessSkillTriggerType
	{
		// Token: 0x040047A6 RID: 18342
		[Token(Token = "0x40047A6")]
		DEFAULT,
		// Token: 0x040047A7 RID: 18343
		[Token(Token = "0x40047A7")]
		ALWAYS,
		// Token: 0x040047A8 RID: 18344
		[Token(Token = "0x40047A8")]
		SEARCH,
		// Token: 0x040047A9 RID: 18345
		[Token(Token = "0x40047A9")]
		MLYSS_WTRMAN,
		// Token: 0x040047AA RID: 18346
		[Token(Token = "0x40047AA")]
		MARCILS2,
		// Token: 0x040047AB RID: 18347
		[Token(Token = "0x40047AB")]
		TRY_SEARCH_ENEMY_SKILL,
		// Token: 0x040047AC RID: 18348
		[Token(Token = "0x40047AC")]
		TRY_SEARCH_ALLY_SKILL,
		// Token: 0x040047AD RID: 18349
		[Token(Token = "0x40047AD")]
		CUSTOM_RANGE_SEARCH_ENEMY,
		// Token: 0x040047AE RID: 18350
		[Token(Token = "0x40047AE")]
		CUSTOM_RANGE_SEARCH_ALLY,
		// Token: 0x040047AF RID: 18351
		[Token(Token = "0x40047AF")]
		GDGLOW_SKILL_2,
		// Token: 0x040047B0 RID: 18352
		[Token(Token = "0x40047B0")]
		ACT_DEFAULT,
		// Token: 0x040047B1 RID: 18353
		[Token(Token = "0x40047B1")]
		AUTO_STOP,
		// Token: 0x040047B2 RID: 18354
		[Token(Token = "0x40047B2")]
		TAKE_DAMAGE
	}
}
