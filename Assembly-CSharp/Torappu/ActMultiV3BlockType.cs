using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E39 RID: 3641
	[Token(Token = "0x2000E39")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3BlockType
	{
		// Token: 0x04004BBD RID: 19389
		[Token(Token = "0x4004BBD")]
		NONE,
		// Token: 0x04004BBE RID: 19390
		[Token(Token = "0x4004BBE")]
		START,
		// Token: 0x04004BBF RID: 19391
		[Token(Token = "0x4004BBF")]
		END,
		// Token: 0x04004BC0 RID: 19392
		[Token(Token = "0x4004BC0")]
		MID
	}
}
