using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E3A RID: 3642
	[Token(Token = "0x2000E3A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3BlockDirType
	{
		// Token: 0x04004BC2 RID: 19394
		[Token(Token = "0x4004BC2")]
		NONE,
		// Token: 0x04004BC3 RID: 19395
		[Token(Token = "0x4004BC3")]
		UP,
		// Token: 0x04004BC4 RID: 19396
		[Token(Token = "0x4004BC4")]
		RIGHT,
		// Token: 0x04004BC5 RID: 19397
		[Token(Token = "0x4004BC5")]
		DOWN,
		// Token: 0x04004BC6 RID: 19398
		[Token(Token = "0x4004BC6")]
		LEFT
	}
}
