using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E38 RID: 3640
	[Token(Token = "0x2000E38")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3MapDiffType
	{
		// Token: 0x04004BB7 RID: 19383
		[Token(Token = "0x4004BB7")]
		NONE,
		// Token: 0x04004BB8 RID: 19384
		[Token(Token = "0x4004BB8")]
		TRAINING,
		// Token: 0x04004BB9 RID: 19385
		[Token(Token = "0x4004BB9")]
		ORDINARY,
		// Token: 0x04004BBA RID: 19386
		[Token(Token = "0x4004BBA")]
		DIFFICULTY,
		// Token: 0x04004BBB RID: 19387
		[Token(Token = "0x4004BBB")]
		EXTREMELY
	}
}
