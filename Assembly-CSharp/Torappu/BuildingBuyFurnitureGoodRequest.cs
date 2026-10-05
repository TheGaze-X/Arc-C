using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public class BuildingBuyFurnitureGoodRequest : BuildingRequest
	{
		// Token: 0x06006268 RID: 25192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006268")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingBuyFurnitureGoodRequest()
		{
		}

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x18")]
		public int buyCount;

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildingBuyFurnitureGoodRequest.CostType costType;

		// Token: 0x0200063A RID: 1594
		[Token(Token = "0x200063A")]
		public enum CostType
		{
			// Token: 0x04002DEC RID: 11756
			[Token(Token = "0x4002DEC")]
			COIN_FURN,
			// Token: 0x04002DED RID: 11757
			[Token(Token = "0x4002DED")]
			DIAMOND
		}
	}
}
