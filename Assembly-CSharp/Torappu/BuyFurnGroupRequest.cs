using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	public class BuyFurnGroupRequest
	{
		// Token: 0x060064DB RID: 25819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyFurnGroupRequest()
		{
		}

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x18")]
		public List<BuyFurnGroupRequest.FurnItemInfo> goods;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuyFurnGroupRequest.CostType costType;

		// Token: 0x02000844 RID: 2116
		[Token(Token = "0x2000844")]
		public enum CostType
		{
			// Token: 0x0400314D RID: 12621
			[Token(Token = "0x400314D")]
			COIN_FURN,
			// Token: 0x0400314E RID: 12622
			[Token(Token = "0x400314E")]
			DIAMOND
		}

		// Token: 0x02000845 RID: 2117
		[Token(Token = "0x2000845")]
		public class FurnItemInfo
		{
			// Token: 0x060064DC RID: 25820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064DC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FurnItemInfo()
			{
			}

			// Token: 0x0400314F RID: 12623
			[Token(Token = "0x400314F")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04003150 RID: 12624
			[Token(Token = "0x4003150")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
