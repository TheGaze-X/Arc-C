using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HalfIdleTrapBuildableType
	{
		// Token: 0x04004184 RID: 16772
		[Token(Token = "0x4004184")]
		NONE,
		// Token: 0x04004185 RID: 16773
		[Token(Token = "0x4004185")]
		HIGHLAND,
		// Token: 0x04004186 RID: 16774
		[Token(Token = "0x4004186")]
		LOWLAND,
		// Token: 0x04004187 RID: 16775
		[Token(Token = "0x4004187")]
		IGNORE_TILE_HEIGHT,
		// Token: 0x04004188 RID: 16776
		[Token(Token = "0x4004188")]
		LHHE,
		// Token: 0x04004189 RID: 16777
		[Token(Token = "0x4004189")]
		LHPLT,
		// Token: 0x0400418A RID: 16778
		[Token(Token = "0x400418A")]
		LHRUIN,
		// Token: 0x0400418B RID: 16779
		[Token(Token = "0x400418B")]
		LHBOT
	}
}
