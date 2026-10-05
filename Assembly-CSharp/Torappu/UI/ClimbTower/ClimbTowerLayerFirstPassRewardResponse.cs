using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C80 RID: 23680
	[Token(Token = "0x2005C80")]
	public class ClimbTowerLayerFirstPassRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060224F8 RID: 140536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224F8")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ClimbTowerLayerFirstPassRewardResponse()
		{
		}

		// Token: 0x0402F1C3 RID: 192963
		[Token(Token = "0x402F1C3")]
		[FieldOffset(Offset = "0x28")]
		public List<ClimbTowerLayerFirstPassRewardResponse.RewardItem> items;

		// Token: 0x02005C81 RID: 23681
		[Token(Token = "0x2005C81")]
		public struct RewardItem : ISharedItemModel, IGachaResultHolder
		{
			// Token: 0x060224F9 RID: 140537 RVA: 0x000BCFE8 File Offset: 0x000BB1E8
			[Token(Token = "0x60224F9")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
			public ItemType GetItemType()
			{
				return ItemType.NONE;
			}

			// Token: 0x060224FA RID: 140538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60224FA")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
			public string GetItemId()
			{
				return null;
			}

			// Token: 0x060224FB RID: 140539 RVA: 0x000BD000 File Offset: 0x000BB200
			[Token(Token = "0x60224FB")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
			public int GetItemCount()
			{
				return 0;
			}

			// Token: 0x060224FC RID: 140540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60224FC")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
			public void SetItemCount(int count_)
			{
			}

			// Token: 0x060224FD RID: 140541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60224FD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			public GachaResult GetGachaResult()
			{
				return null;
			}

			// Token: 0x0402F1C4 RID: 192964
			[Token(Token = "0x402F1C4")]
			[FieldOffset(Offset = "0x0")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x0402F1C5 RID: 192965
			[Token(Token = "0x402F1C5")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x0402F1C6 RID: 192966
			[Token(Token = "0x402F1C6")]
			[FieldOffset(Offset = "0x10")]
			public GachaResult charGet;

			// Token: 0x0402F1C7 RID: 192967
			[Token(Token = "0x402F1C7")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
