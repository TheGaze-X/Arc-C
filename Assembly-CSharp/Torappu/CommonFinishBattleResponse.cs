using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200070C RID: 1804
	[Token(Token = "0x200070C")]
	public abstract class CommonFinishBattleResponse : PlayerDeltaResponse, IAlertResponse
	{
		// Token: 0x0600636A RID: 25450
		[Token(Token = "0x600636A")]
		public abstract void GetGoldAndExpScale(out float goldScale, out float expScale);

		// Token: 0x0600636B RID: 25451
		[Token(Token = "0x600636B")]
		public abstract List<CommonFinishBattleResponse.RewardModel> GetFirstRewards();

		// Token: 0x0600636C RID: 25452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
		public virtual List<PryResult> GetPryResults()
		{
			return null;
		}

		// Token: 0x0600636D RID: 25453
		[Token(Token = "0x600636D")]
		public abstract string[] GetUnlockStages();

		// Token: 0x0600636E RID: 25454
		[Token(Token = "0x600636E")]
		public abstract List<ServiceAlertStruct> GetAlert();

		// Token: 0x0600636F RID: 25455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		protected CommonFinishBattleResponse()
		{
		}

		// Token: 0x04002F3A RID: 12090
		[Token(Token = "0x4002F3A")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x2C")]
		public int apFailReturn;

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x30")]
		public List<CommonFinishBattleResponse.RewardModel> itemReturn;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x38")]
		public List<CommonFinishBattleResponse.RewardModel> rewards;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x40")]
		public List<CommonFinishBattleResponse.RewardModel> unusualRewards;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x48")]
		public List<CommonFinishBattleResponse.RewardModel> overrideRewards;

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x50")]
		public List<CommonFinishBattleResponse.RewardModel> additionalRewards;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x58")]
		public List<CommonFinishBattleResponse.RewardModel> diamondMaterialRewards;

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0x60")]
		public List<CommonFinishBattleResponse.RewardModel> furnitureRewards;

		// Token: 0x0200070D RID: 1805
		[Token(Token = "0x200070D")]
		public class RewardModel : ISharedItemModel, IGachaResultHolder
		{
			// Token: 0x06006370 RID: 25456 RVA: 0x00030408 File Offset: 0x0002E608
			[Token(Token = "0x6006370")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
			public ItemType GetItemType()
			{
				return ItemType.NONE;
			}

			// Token: 0x06006371 RID: 25457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006371")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			public string GetItemId()
			{
				return null;
			}

			// Token: 0x06006372 RID: 25458 RVA: 0x00030420 File Offset: 0x0002E620
			[Token(Token = "0x6006372")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "6")]
			public int GetItemCount()
			{
				return 0;
			}

			// Token: 0x06006373 RID: 25459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006373")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10", Slot = "7")]
			public void SetItemCount(int count_)
			{
			}

			// Token: 0x06006374 RID: 25460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006374")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			public GachaResult GetGachaResult()
			{
				return null;
			}

			// Token: 0x06006375 RID: 25461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006375")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardModel()
			{
			}

			// Token: 0x04002F43 RID: 12099
			[Token(Token = "0x4002F43")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04002F44 RID: 12100
			[Token(Token = "0x4002F44")]
			[FieldOffset(Offset = "0x18")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x04002F45 RID: 12101
			[Token(Token = "0x4002F45")]
			[FieldOffset(Offset = "0x1C")]
			public int count;

			// Token: 0x04002F46 RID: 12102
			[Token(Token = "0x4002F46")]
			[FieldOffset(Offset = "0x20")]
			public GachaResult charGet;
		}
	}
}
