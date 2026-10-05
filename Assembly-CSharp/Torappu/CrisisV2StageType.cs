using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FAE RID: 4014
	[Token(Token = "0x2000FAE")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2StageType
	{
		// Token: 0x04005531 RID: 21809
		[Token(Token = "0x4005531")]
		NONE,
		// Token: 0x04005532 RID: 21810
		[Token(Token = "0x4005532")]
		PERMANENT,
		// Token: 0x04005533 RID: 21811
		[Token(Token = "0x4005533")]
		TEMPORARY
	}
}
