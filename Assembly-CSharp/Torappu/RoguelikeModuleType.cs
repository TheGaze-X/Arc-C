using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011CA RID: 4554
	[Token(Token = "0x20011CA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeModuleType
	{
		// Token: 0x0400618B RID: 24971
		[Token(Token = "0x400618B")]
		NONE,
		// Token: 0x0400618C RID: 24972
		[Token(Token = "0x400618C")]
		SANCHECK,
		// Token: 0x0400618D RID: 24973
		[Token(Token = "0x400618D")]
		DICE,
		// Token: 0x0400618E RID: 24974
		[Token(Token = "0x400618E")]
		CHAOS,
		// Token: 0x0400618F RID: 24975
		[Token(Token = "0x400618F")]
		TOTEMBUFF,
		// Token: 0x04006190 RID: 24976
		[Token(Token = "0x4006190")]
		VISION,
		// Token: 0x04006191 RID: 24977
		[Token(Token = "0x4006191")]
		FRAGMENT,
		// Token: 0x04006192 RID: 24978
		[Token(Token = "0x4006192")]
		DISASTER,
		// Token: 0x04006193 RID: 24979
		[Token(Token = "0x4006193")]
		NODE_UPGRADE,
		// Token: 0x04006194 RID: 24980
		[Token(Token = "0x4006194")]
		COPPER,
		// Token: 0x04006195 RID: 24981
		[Token(Token = "0x4006195")]
		WRATH,
		// Token: 0x04006196 RID: 24982
		[Token(Token = "0x4006196")]
		CANDLE,
		// Token: 0x04006197 RID: 24983
		[Token(Token = "0x4006197")]
		SKY
	}
}
