using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013B8 RID: 5048
	[Token(Token = "0x20013B8")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VoiceLangGroupType
	{
		// Token: 0x04007043 RID: 28739
		[Token(Token = "0x4007043")]
		NONE,
		// Token: 0x04007044 RID: 28740
		[Token(Token = "0x4007044")]
		CN_MANDARIN,
		// Token: 0x04007045 RID: 28741
		[Token(Token = "0x4007045")]
		JP,
		// Token: 0x04007046 RID: 28742
		[Token(Token = "0x4007046")]
		EN,
		// Token: 0x04007047 RID: 28743
		[Token(Token = "0x4007047")]
		KR,
		// Token: 0x04007048 RID: 28744
		[Token(Token = "0x4007048")]
		CUSTOM,
		// Token: 0x04007049 RID: 28745
		[Token(Token = "0x4007049")]
		LINKAGE
	}
}
