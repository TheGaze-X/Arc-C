using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200136F RID: 4975
	[Token(Token = "0x200136F")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Serializable]
	public enum SixStarStageCompatibleDropType
	{
		// Token: 0x04006E46 RID: 28230
		[Token(Token = "0x4006E46")]
		COMPLETE_ONLY
	}
}
