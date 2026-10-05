using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013B7 RID: 5047
	[Token(Token = "0x20013B7")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VoiceLangType
	{
		// Token: 0x04007036 RID: 28726
		[Token(Token = "0x4007036")]
		NONE,
		// Token: 0x04007037 RID: 28727
		[Token(Token = "0x4007037")]
		JP,
		// Token: 0x04007038 RID: 28728
		[Token(Token = "0x4007038")]
		CN_MANDARIN,
		// Token: 0x04007039 RID: 28729
		[Token(Token = "0x4007039")]
		EN,
		// Token: 0x0400703A RID: 28730
		[Token(Token = "0x400703A")]
		KR,
		// Token: 0x0400703B RID: 28731
		[Token(Token = "0x400703B")]
		CN_TOPOLECT,
		// Token: 0x0400703C RID: 28732
		[Token(Token = "0x400703C")]
		LINKAGE,
		// Token: 0x0400703D RID: 28733
		[Token(Token = "0x400703D")]
		ITA,
		// Token: 0x0400703E RID: 28734
		[Token(Token = "0x400703E")]
		GER,
		// Token: 0x0400703F RID: 28735
		[Token(Token = "0x400703F")]
		RUS,
		// Token: 0x04007040 RID: 28736
		[Token(Token = "0x4007040")]
		FRE,
		// Token: 0x04007041 RID: 28737
		[Token(Token = "0x4007041")]
		SPA
	}
}
