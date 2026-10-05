using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x20006AE")]
	public class CampaignConfirmBreakRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060062EA RID: 25322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CampaignConfirmBreakRewardResponse()
		{
		}

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x28")]
		public int feeAdd;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x30")]
		public List<CampaignConfirmBreakRewardResponse.RewardItem> items;

		// Token: 0x020006AF RID: 1711
		[Token(Token = "0x20006AF")]
		public class RewardItem : ISharedItemModel, IGachaResultHolder
		{
			// Token: 0x060062EB RID: 25323 RVA: 0x000302E8 File Offset: 0x0002E4E8
			[Token(Token = "0x60062EB")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			public ItemType GetItemType()
			{
				return ItemType.NONE;
			}

			// Token: 0x060062EC RID: 25324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062EC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			public string GetItemId()
			{
				return null;
			}

			// Token: 0x060062ED RID: 25325 RVA: 0x00030300 File Offset: 0x0002E500
			[Token(Token = "0x60062ED")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "6")]
			public int GetItemCount()
			{
				return 0;
			}

			// Token: 0x060062EE RID: 25326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EE")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630", Slot = "7")]
			public void SetItemCount(int count_)
			{
			}

			// Token: 0x060062EF RID: 25327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062EF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			public GachaResult GetGachaResult()
			{
				return null;
			}

			// Token: 0x060062F0 RID: 25328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardItem()
			{
			}

			// Token: 0x04002E98 RID: 11928
			[Token(Token = "0x4002E98")]
			[FieldOffset(Offset = "0x10")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x04002E99 RID: 11929
			[Token(Token = "0x4002E99")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04002E9A RID: 11930
			[Token(Token = "0x4002E9A")]
			[FieldOffset(Offset = "0x20")]
			public GachaResult charGet;

			// Token: 0x04002E9B RID: 11931
			[Token(Token = "0x4002E9B")]
			[FieldOffset(Offset = "0x28")]
			public int count;
		}
	}
}
