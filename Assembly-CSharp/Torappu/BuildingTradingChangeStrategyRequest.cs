using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public class BuildingTradingChangeStrategyRequest
	{
		// Token: 0x06006282 RID: 25218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006282")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingTradingChangeStrategyRequest()
		{
		}

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildingData.OrderType strategy;
	}
}
