using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessPrepareStepType
	{
		// Token: 0x0400479A RID: 18330
		[Token(Token = "0x400479A")]
		NONE,
		// Token: 0x0400479B RID: 18331
		[Token(Token = "0x400479B")]
		INFO_CHECK,
		// Token: 0x0400479C RID: 18332
		[Token(Token = "0x400479C")]
		BAND_CHECK,
		// Token: 0x0400479D RID: 18333
		[Token(Token = "0x400479D")]
		BATTLE_CHECK
	}
}
